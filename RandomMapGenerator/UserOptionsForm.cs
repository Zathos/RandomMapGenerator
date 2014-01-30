using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomMapGenerator.Constants;

namespace RandomMapGenerator
{


    public partial class UserOptionsForm : Form
    {
        public UserOptionsForm()
        {
            InitializeComponent();           
            OutputTypePicker.DataSource = Enum.GetValues(typeof(OutputType));
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var inputvalues = GetInputValues();
            if (inputvalues != null)
            {
                var message = inputvalues.ToString();
                var results = MessageBox.Show(message, "Confirm", MessageBoxButtons.OKCancel);
                if (results == DialogResult.OK)
                {
                    //TODO Do it!
                    MessageBox.Show("Doing it, is the plan");
                }
            }
        }

        private InputValues GetInputValues()
        {
            bool inputsValidate = true;
            ClearErrors();

            OutputType outputType;
            var mapTypeParsed = Enum.TryParse<OutputType>(OutputTypePicker.SelectedValue.ToString(), out outputType);
            if (mapTypeParsed == false)
            {
                ErrorOutputType.Visible = true;
                inputsValidate = false;
            }

            if (OutputPath.Text == string.Empty)
            {
                ErrorOutputPath.Visible = true;
                inputsValidate = false;
            }

            int axisTry;
            if (!int.TryParse(XAxisTextBox.Text, out axisTry))
            {
                ErrorXAxis.Visible = true;
                inputsValidate = false;
            }

            if (!int.TryParse(YAxisTextBox.Text, out axisTry))
            {
                ErrorYAxis.Visible = true;
                inputsValidate = false;
            }

            if (!int.TryParse(ZAxisTextBox.Text, out axisTry))
            {
                ErrorZAxis.Visible = true;
                inputsValidate = false;
            }

            InputValues inputValues = null;
            if (inputsValidate)
            {
                inputValues = new InputValues
                {
                    MapType = outputType,
                    OutputPath = OutputPath.Text,
                    XSize = int.Parse(XAxisTextBox.Text),
                    YSize = int.Parse(YAxisTextBox.Text),
                    ZSize = int.Parse(ZAxisTextBox.Text),
                };
            }

            return inputValues;
        }

        private void ClearErrors()
        {
            ErrorOutputType.Visible = false;
            ErrorOutputPath.Visible = false;
            ErrorXAxis.Visible = false;
            ErrorYAxis.Visible = false;
            ErrorZAxis.Visible = false;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (FolderPicker.ShowDialog() == DialogResult.OK)
            {
                OutputPath.Text = FolderPicker.SelectedPath;
            }
        }
    }
}
