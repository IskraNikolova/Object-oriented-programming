namespace LambdaCore_Skeleton.Models.Cores
{
    using Enums;

    public class ParaBaseCore : BaseCore
    {        
        public ParaBaseCore(char name, int startDurability) 
            : base(name, CoreType.Para, startDurability)
        {
        }
    }
}