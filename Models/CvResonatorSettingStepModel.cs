using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.Services;

namespace ResonatorTestManagement.Models
{
    public class CvResonatorSettingStepModel
    {


        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSettingStepService _service = new CvResonatorSettingStepService();

        public OutputOnDbProperty SearchByPurchaseId(CvResonatorSettingStepProperty dataItem)
        {
            _resultData = _service.SearchByPurchaseId(dataItem);
            return _resultData;
        }

    }
}