using BusinessData.Interface;
using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.SQLFactory;
using System;

namespace ResonatorTestManagement.Services
{
    public class CvResonatorSettingStepService : DatabaseAction<CvResonatorSettingStepProperty>
    {
        CvResonatorSettingStepSQLFactory _sqlFactory = new CvResonatorSettingStepSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Search(CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty SearchByPurchaseId(CvResonatorSettingStepProperty dataItem)
        {
            string sql = _sqlFactory.SearchByPurchaseId(dataItem);
            _resultData = base.SearchBySql(sql);
            return _resultData;
        }


        public override OutputOnDbProperty Insert(CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Delete(CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }


    }
}