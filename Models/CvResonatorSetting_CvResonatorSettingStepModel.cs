using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.Services;

namespace ResonatorTestManagement.Models
{
    public class CvResonatorSetting_CvResonatorSettingStepModel
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSetting_CvResonatorSettingStepService _service = new CvResonatorSetting_CvResonatorSettingStepService();

        public OutputOnDbProperty InsertAndUpdateInuse(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            _resultData = _service.InsertAndUpdateInuse(dataItem);
            return _resultData;
        }

    }
}