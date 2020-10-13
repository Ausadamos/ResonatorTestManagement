using BusinessData.Property;
using ResonatorTestManagement.Models;
using ResonatorTestManagement.Property;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ResonatorTestManagement.Controller
{
    public class CvResonatorSettingStepController
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSettingStepModel _model = new CvResonatorSettingStepModel();

        public List<CvResonatorSettingStepProperty> SearchByPurchaseId(CvResonatorSettingStepProperty dataItem)
        {
            List<CvResonatorSettingStepProperty> listItem = new List<CvResonatorSettingStepProperty>();
            try
            {
                _resultData = _model.SearchByPurchaseId(dataItem);
                if (_resultData.StatusOnDb == true)
                {
                    foreach (DataRow row in _resultData.ResultOnDb.Rows)
                    {
                        CvResonatorSettingStepProperty productProperty = new CvResonatorSettingStepProperty
                        {
                            ID = row["ID"].ToString(),
                            PURCHASE_ID = row["PURCHASE_ID"].ToString(),
                            STEP_NUMBER = row["STEP_NUMBER"].ToString(),
                            VOLTAGE = row["VOLTAGE"].ToString(),
                            CREATE_DATE = row["CREATE_DATE"].ToString(),
                            LAST_DATE = row["LAST_DATE"].ToString(),
                            IP_ADDRESS = row["IP_ADDRESS"].ToString(),
                            NAME_ADDRESS = row["NAME_ADDRESS"].ToString(),
                            USER_CREATE = row["USER_CREATE"].ToString(),
                            USER_UPDATE = row["USER_UPDATE"].ToString(),
                            INUSE = row["INUSE"].ToString(),

                        };

                        listItem.Add(productProperty);
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

            return listItem;
        }
    }
}