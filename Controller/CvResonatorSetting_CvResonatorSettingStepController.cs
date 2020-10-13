using BusinessData.Property;
using ResonatorTestManagement.Models;
using ResonatorTestManagement.Property;
using System;
using System.Windows.Forms;

namespace ResonatorTestManagement.Controller
{
    public class CvResonatorSetting_CvResonatorSettingStepController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSetting_CvResonatorSettingStepModel _model = new CvResonatorSetting_CvResonatorSettingStepModel();

        public bool InsertAndUpdateInuse(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            bool result = true;
            try
            {
                _resultData = _model.InsertAndUpdateInuse(dataItem);
                if (_resultData.StatusOnDb == false)
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }

            return result;
        }

    }
}