using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yixing.model;

namespace Yixing.util
{
    public class CheckEdit
    {

        //记录单独状态的DIC 包括高级和转涅
        public Dictionary<int, DCStatus> ztDic = new Dictionary<int, DCStatus>();
        //记录单独转涅的DIC 包括高级和转涅
        public Dictionary<int, DCZhuannie> znDic = new Dictionary<int, DCZhuannie>();
        //记录单独高级的DIC 包括高级和转涅
        public Dictionary<int, DCGaoji> gjDic = new Dictionary<int, DCGaoji>();

        List<int> ztKeyList = new List<int>();

        public CheckEdit(List<int> ztKeyList_, Dictionary<int, DCStatus> ztDic_, Dictionary<int, DCZhuannie> znDic_, Dictionary<int, DCGaoji> gjDic_)
        {
            this.ztDic = ztDic_;
            this.znDic = znDic_;
            this.gjDic = gjDic_;
            this.ztKeyList = ztKeyList_;
        }

        //检查马赫数
        public Boolean checkmh()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    if (dcs.mahe != dcs1.mahe)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //检查升力系数
        public Boolean checkslxs()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    //若为0，证明没有设定升力系数，则不可用
                    if (dcs1.dslxs == 0)
                    { return false; }
                    if (dcs.dslxs != dcs1.dslxs)
                    {return false;}
                }
            }
            return true;
        }

        //检查定迎角
        public Boolean checkdyj()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    //若为0，证明没有设定升力系数，则不可用
                    if (dcs1.dyj == 0)
                    { return false; }
                    if (dcs.dyj != dcs1.dyj)
                    { return false; }
                }
            }
            return true;
        }

        //检查离散格式
        public Boolean checklsgs()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    if (dcs.lsgs != dcs1.lsgs)
                    { return false; }
                }
            }
            return true;
        }

        //检查端流模型
        public Boolean checkdlmx()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    if (dcs.dlmx != dcs1.dlmx)
                    { return false; }
                }
            }
            return true;
        }

        //检查端流模型
        public Boolean checkznfd()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int znkey = dcs.znKey;
                //如果key为0，证明没有，直接继续
                if (znkey == 0) {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int znkey1 = dcs.znKey;
                        //如果key为0，证明没有，直接继续
                        if (znkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCZhuannie zn = znDic[znkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int znkey1 = dcs1.znKey;
                    //如果key为0，证明没有，直接继续
                    if (znkey1 == 0) { return false; }
                    DCZhuannie zn1 = znDic[znkey1];
                    if (zn.fddls != zn1.fddls)
                    { return false; }
                }
            }
            return true;
        }

        //检查涡粘性比
        public Boolean checkznwnxb()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int znkey = dcs.znKey;
                //如果key为0，证明没有，直接继续
                //如果key为0，证明没有，直接继续
                if (znkey == 0)
                {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int znkey1 = dcs.znKey;
                        //如果key为0，证明没有，直接继续
                        if (znkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCZhuannie zn = znDic[znkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int znkey1 = dcs1.znKey;
                    //如果key为0，证明没有，直接继续
                    if (znkey1 == 0) { return false; }
                    DCZhuannie zn1 = znDic[znkey1];
                    if (zn.wnxb != zn1.wnxb)
                    { return false; }
                }
            }
            return true;
        }

        //检查CFL
        public Boolean checkgjcfl()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int gjkey = dcs.gjKey;
                //如果key为0，检查其他几项是否为0
                //若有一个不为0，则必定不可以修改
                //若为0，且没有returned则都可以修改，所以直接break不管后续操作了
                if (gjkey == 0)
                {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int gjkey1 = dcs.gjKey;
                        //如果key为0，证明没有，直接继续
                        if (gjkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCGaoji gj = gjDic[gjkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int gjkey1 = dcs.gjKey;
                    //如果key为0，证明没有，直接继续
                    if (gjkey1 == 0) { return false; }
                    DCGaoji gj1 = gjDic[gjkey1];
                    if (gj.cfl != gj1.cfl)
                    { return false; }
                }
            }
            return true;
        }

        //检查第一重迭代
        public Boolean checkgjonedd()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int gjkey = dcs.gjKey;
                //如果key为0，检查其他几项是否为0
                //若有一个不为0，则必定不可以修改
                //若为0，且没有returned则都可以修改，所以直接break不管后续操作了
                if (gjkey == 0)
                {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int gjkey1 = dcs.gjKey;
                        //如果key为0，证明没有，直接继续
                        if (gjkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCGaoji gj = gjDic[gjkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int gjkey1 = dcs.gjKey;
                    //如果key为0，证明没有，直接继续，走到此处 为0，必定和gj不同
                    if (gjkey1 == 0) { return false; }
                    DCGaoji gj1 = gjDic[gjkey1];
                    if (gj.onedd != gj1.onedd)
                    { return false; }
                }
            }
            return true;
        }

        //检查第二重迭代
        public Boolean checkgjsecdd()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int gjkey = dcs.gjKey;
                //如果key为0，检查其他几项是否为0
                //若有一个不为0，则必定不可以修改
                //若为0，且没有returned则都可以修改，所以直接break不管后续操作了
                if (gjkey == 0)
                {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int gjkey1 = dcs.gjKey;
                        //如果key为0，证明没有，直接继续
                        if (gjkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCGaoji gj = gjDic[gjkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int gjkey1 = dcs.gjKey;
                    //如果key为0，证明没有，直接继续
                    if (gjkey1 == 0) { return false; }
                    DCGaoji gj1 = gjDic[gjkey1];
                    if (gj.secdd != gj1.secdd)
                    { return false; }
                }
            }
            return true;
        }


        //检查第三重迭代
        public Boolean checkgjthirdd()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int gjkey = dcs.gjKey;
                //如果key为0，检查其他几项是否为0
                //若有一个不为0，则必定不可以修改
                //若为0，且没有returned则都可以修改，所以直接break不管后续操作了
                if (gjkey == 0)
                {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int gjkey1 = dcs.gjKey;
                        //如果key为0，证明没有，直接继续
                        if (gjkey1 == 0) { continue; } else { return false; }
                    }
                    break;
                }
                DCGaoji gj = gjDic[gjkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int gjkey1 = dcs.gjKey;
                    //如果key为0，证明没有，直接继续
                    if (gjkey1 == 0) { return false; }
                    DCGaoji gj1 = gjDic[gjkey1];
                    if (gj.thirdd != gj1.thirdd)
                    { return false; }
                }
            }
            return true;
        }

        //检查修正熵
        public Boolean checkgjxzs()
        {
            for (int i = 0; i < ztKeyList.Count; i++)
            {
                int ztKey = ztKeyList[i];
                DCStatus dcs = ztDic[ztKey];
                int gjkey = dcs.gjKey;
                //如果key为0，检查其他几项是否为0
                //若有一个不为0，则必定不可以修改
                //若为0，且没有returned则都可以修改，所以直接break不管后续操作了
                if (gjkey == 0) {
                    for (int j = i + 1; j < ztKeyList.Count; j++)
                    {
                        int ztKey1 = ztKeyList[j];
                        DCStatus dcs1 = ztDic[ztKey1];
                        int gjkey1 = dcs.gjKey;
                        //如果key为0，证明没有，直接继续
                        if (gjkey1 == 0) { continue; } else { return false; }
                    }
                   break; 
                }
                DCGaoji gj = gjDic[gjkey];
                for (int j = i + 1; j < ztKeyList.Count; j++)
                {
                    int ztKey1 = ztKeyList[j];
                    DCStatus dcs1 = ztDic[ztKey1];
                    int gjkey1 = dcs.gjKey;
                    //如果key为0，证明没有，直接继续
                    if (gjkey1 == 0) { return false; }
                    DCGaoji gj1 = gjDic[gjkey1];
                    if (gj.xzs != gj1.xzs)
                    { return false; }
                }
            }
            return true;
        }
    }
}
