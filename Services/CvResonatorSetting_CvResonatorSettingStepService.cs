using BusinessData.Interface;
using BusinessData.Property;
using ResonatorTestManagement.Property;
using ResonatorTestManagement.SQLFactory;
using System;
using System.Collections.Generic;

namespace ResonatorTestManagement.Services
{
    public class CvResonatorSetting_CvResonatorSettingStepService : DatabaseAction<CvResonatorSetting_CvResonatorSettingStepProperty>
    {

        CvResonatorSettingSQLFactory _sqlFactoryCvResonatorSetting = new CvResonatorSettingSQLFactory();
        CvResonatorSettingStepSQLFactory _sqlFactoryCvResonatorSettingStep = new CvResonatorSettingStepSQLFactory();
        OutputOnDbProperty _resultData = new OutputOnDbProperty();

        public override OutputOnDbProperty Delete(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Insert(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Search()
        {
            throw new NotImplementedException();
        }

        public override OutputOnDbProperty Update(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            throw new NotImplementedException();
        }

        public OutputOnDbProperty InsertAndUpdateInuse(CvResonatorSetting_CvResonatorSettingStepProperty dataItem)
        {
            List<string> listSql = new List<string>();


            listSql.Add(_sqlFactoryCvResonatorSetting.Delete(dataItem.CV_RESONATOR_SETTING));
            listSql.Add(_sqlFactoryCvResonatorSetting.Insert(dataItem.CV_RESONATOR_SETTING));


            listSql.Add(_sqlFactoryCvResonatorSettingStep.Delete(dataItem.LIST_CV_RESONATOR_SETTING_STEP[0]));
            foreach (CvResonatorSettingStepProperty data in dataItem.LIST_CV_RESONATOR_SETTING_STEP)
            {
                listSql.Add(_sqlFactoryCvResonatorSettingStep.Insert(data));
            }

            _resultData = base.InsertBySqlList(listSql);
            return _resultData;

        }

    }
}