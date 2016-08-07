namespace LambdaCore_Skeleton.Models.Cores
{
    using Enums;

    public class SystemBaseCore : BaseCore
    {
        public SystemBaseCore(char name, int _startDurability) 
            : base(name, CoreType.System, _startDurability)
        {
        }
    }
}