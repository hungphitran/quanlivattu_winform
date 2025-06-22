using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class DataGridViewCalendarColumn : DataGridViewColumn
{
    public DataGridViewCalendarColumn() : base(new DataGridViewCalendarCell())
    {
        this.DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    public override DataGridViewCell CellTemplate
    {
        get => base.CellTemplate;
        set
        {
            if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewCalendarCell)))
                throw new InvalidCastException("Phải là DataGridViewCalendarCell");
            base.CellTemplate = value;
        }
    }
}

public class DataGridViewCalendarCell : DataGridViewTextBoxCell
{
    public DataGridViewCalendarCell()
    {
        this.Style.Format = "dd/MM/yyyy";
    }

    public override void InitializeEditingControl(int rowIndex, object initialFormattedValue,
        DataGridViewCellStyle dataGridViewCellStyle)
    {
        base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
        var ctl = (CalendarEditingControl)DataGridView.EditingControl;
        if (this.Value == null || this.Value == DBNull.Value)
            ctl.Value = DateTime.Today;
        else
            ctl.Value = Convert.ToDateTime(this.Value);
    }

    public override Type EditType => typeof(CalendarEditingControl);
    public override Type ValueType => typeof(DateTime);
    public override object DefaultNewRowValue => DateTime.Today;
}

class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
{
    private DataGridView dataGridView;
    private bool valueChanged = false;
    private int rowIndex;

    public CalendarEditingControl()
    {
        this.Format = DateTimePickerFormat.Custom;
        this.CustomFormat = "dd/MM/yyyy";
    }

    public object EditingControlFormattedValue
    {
        get => this.Value.ToString("dd/MM/yyyy");
        set
        {
            if (DateTime.TryParse(value?.ToString(), out DateTime result))
            {
                this.Value = result;
            }
        }
    }

    public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        => EditingControlFormattedValue;

    public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
    {
        this.Font = dataGridViewCellStyle.Font;
        this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
        this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    public int EditingControlRowIndex { get => rowIndex; set => rowIndex = value; }
    public bool EditingControlValueChanged { get => valueChanged; set => valueChanged = value; }
    public bool RepositionEditingControlOnValueChange => false;
    public DataGridView EditingControlDataGridView { get => dataGridView; set => dataGridView = value; }
    public Cursor EditingPanelCursor => base.Cursor;
    public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey) => true;

    public void PrepareEditingControlForEdit(bool selectAll) { }

    protected override void OnValueChanged(EventArgs eventargs)
    {
        valueChanged = true;
        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
        base.OnValueChanged(eventargs);
    }
}
