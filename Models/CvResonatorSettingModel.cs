using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.Services;

namespace ResonatorTestManagement.Models
{
    public class CvResonatorSettingModel
    {

        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CvResonatorSettingService _service = new CvResonatorSettingService();

        public OutputOnDbProperty Search(CvResonatorSettingProperty dataItem)
        {
            _resultData = _service.Search(dataItem);
            return _resultData;
        }

    }
}