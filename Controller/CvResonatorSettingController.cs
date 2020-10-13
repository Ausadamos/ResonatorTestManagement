using BusinessData.Property;
using ResonatorTestManagement.Models;
using ResonatorTestManagement.Property;
using System;
using System.Windows.Forms;

namespace ResonatorTestManagement.Controller
{
    public class CvResonatorSettingController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSettingModel _model = new CvResonatorSettingModel();

        public CvResonatorSettingProperty Search(CvResonatorSettingProperty dataItem)
        {
            CvResonatorSettingProperty _property = null;
            try
            {
                _resultData = _model.Search(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        _property = new CvResonatorSettingProperty
                        {
                            ID = _resultData.ResultOnDb.Rows[0]["ID"].ToString(),
                            PURCHASE_ID = _resultData.ResultOnDb.Rows[0]["PURCHASE_ID"].ToString(),
                            EFF_NEED = _resultData.ResultOnDb.Rows[0]["EFF_NEED"].ToString(),
                            EFF_MIN_SLOPE = _resultData.ResultOnDb.Rows[0]["EFF_MIN_SLOPE"].ToString(),
                            EFF_MAX_SLOPE = _resultData.ResultOnDb.Rows[0]["EFF_MAX_SLOPE"].ToString(),
                            EFF_MIN_R2 = _resultData.ResultOnDb.Rows[0]["EFF_MIN_R2"].ToString(),
                            EFF_MAX_R2 = _resultData.ResultOnDb.Rows[0]["EFF_MAX_R2"].ToString(),
                            OC_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["OC_TEMP_NEED"].ToString(),
                            OC_TEMP_MIN_SLOPE = _resultData.ResultOnDb.Rows[0]["OC_TEMP_MIN_SLOPE"].ToString(),
                            OC_TEMP_MAX_SLOPE = _resultData.ResultOnDb.Rows[0]["OC_TEMP_MAX_SLOPE"].ToString(),
                            OC_TEMP_MIN_R2 = _resultData.ResultOnDb.Rows[0]["OC_TEMP_MIN_R2"].ToString(),
                            OC_TEMP_MAX_R2 = _resultData.ResultOnDb.Rows[0]["OC_TEMP_MAX_R2"].ToString(),
                            HR_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["HR_TEMP_NEED"].ToString(),
                            HR_TEMP_MIN_SLOPE = _resultData.ResultOnDb.Rows[0]["HR_TEMP_MIN_SLOPE"].ToString(),
                            HR_TEMP_MAX_SLOPE = _resultData.ResultOnDb.Rows[0]["HR_TEMP_MAX_SLOPE"].ToString(),
                            HR_TEMP_MIN_R2 = _resultData.ResultOnDb.Rows[0]["HR_TEMP_MIN_R2"].ToString(),
                            HR_TEMP_MAX_R2 = _resultData.ResultOnDb.Rows[0]["HR_TEMP_MAX_R2"].ToString(),
                            COLDPLATE_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["COLDPLATE_TEMP_NEED"].ToString(),
                            COLDPLATE_TEMP_MIN_SLOPE = _resultData.ResultOnDb.Rows[0]["COLDPLATE_TEMP_MIN_SLOPE"].ToString(),
                            COLDPLATE_TEMP_MAX_SLOPE = _resultData.ResultOnDb.Rows[0]["COLDPLATE_TEMP_MAX_SLOPE"].ToString(),
                            COLDPLATE_TEMP_MIN_R2 = _resultData.ResultOnDb.Rows[0]["COLDPLATE_TEMP_MIN_R2"].ToString(),
                            COLDPLATE_TEMP_MAX_R2 = _resultData.ResultOnDb.Rows[0]["COLDPLATE_TEMP_MAX_R2"].ToString(),
                            RESIDUAL_NEED = _resultData.ResultOnDb.Rows[0]["RESIDUAL_NEED"].ToString(),
                            RESIDUAL_MIN_SIGNAL_FW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MIN_SIGNAL_FW"].ToString(),
                            RESIDUAL_MAX_SIGNAL_FW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MAX_SIGNAL_FW"].ToString(),
                            RESIDUAL_MIN_SIGNAL_BW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MIN_SIGNAL_BW"].ToString(),
                            RESIDUAL_MAX_SIGNAL_BW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MAX_SIGNAL_BW"].ToString(),
                            RESIDUAL_MIN_PUMP_FW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MIN_PUMP_FW"].ToString(),
                            RESIDUAL_MAX_PUMP_FW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MAX_PUMP_FW"].ToString(),
                            RESIDUAL_MIN_PUMP_BW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MIN_PUMP_BW"].ToString(),
                            RESIDUAL_MAX_PUMP_BW = _resultData.ResultOnDb.Rows[0]["RESIDUAL_MAX_PUMP_BW"].ToString(),
                            CENTERPORT_NEED = _resultData.ResultOnDb.Rows[0]["CENTERPORT_NEED"].ToString(),
                            CENTERPORT_SIGNAL_MIN = _resultData.ResultOnDb.Rows[0]["CENTERPORT_SIGNAL_MIN"].ToString(),
                            CENTERPORT_SIGNAL_MAX = _resultData.ResultOnDb.Rows[0]["CENTERPORT_SIGNAL_MAX"].ToString(),
                            CENTERPORT_PUMP_MIN = _resultData.ResultOnDb.Rows[0]["CENTERPORT_PUMP_MIN"].ToString(),
                            CENTERPORT_PUMP_MAX = _resultData.ResultOnDb.Rows[0]["CENTERPORT_PUMP_MAX"].ToString(),
                            INCREASE_STEP = _resultData.ResultOnDb.Rows[0]["INCREASE_STEP"].ToString(),
                            OUTPUT_TEMP_NEED = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMP_NEED"].ToString(),
                            OUTPUT_TEMP_MIN_POINT1 = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMP_MIN_POINT1"].ToString(),
                            OUTPUT_TEMP_MAX_POINT1 = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMP_MAX_POINT1"].ToString(),
                            OUTPUT_TEMP_MIN_POINT2 = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMP_MIN_POINT2"].ToString(),
                            OUTPUT_TEMP_MAX_POINT2 = _resultData.ResultOnDb.Rows[0]["OUTPUT_TEMP_MAX_POINT2"].ToString(),
                            CREATE_DATE = _resultData.ResultOnDb.Rows[0]["CREATE_DATE"].ToString(),
                            IP_ADDRESS = _resultData.ResultOnDb.Rows[0]["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = _resultData.ResultOnDb.Rows[0]["NAME_ADDRESS"].ToString(),
                            USER_CREATE = _resultData.ResultOnDb.Rows[0]["USER_CREATE"].ToString(),
                            LAST_DATE = _resultData.ResultOnDb.Rows[0]["LAST_DATE"].ToString(),
                            USER_UPDATE = _resultData.ResultOnDb.Rows[0]["USER_UPDATE"].ToString(),
                            INUSE = _resultData.ResultOnDb.Rows[0]["INUSE"].ToString(),


                        };
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _property;
        }
    }
}