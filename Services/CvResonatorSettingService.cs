using BusinessData.Interface;
using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.SQLFactory;
using System;

namespace ResonatorTestManagement.Services
{
    public class CvResonatorSettingService : DatabaseAction<CvResonatorSettingProperty>
    {
        CvResonatorSettingSQLFactory _sqlFactory = new CvResonatorSettingSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Search(CvResonatorSettingProperty dataItem)
        {
            string sql = _sqlFactory.Search(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvResonatorSettingProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(CvResonatorSettingProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Delete(CvResonatorSettingProperty dataItem)
        {
            throw new NotImplementedException();
        }


    }
}