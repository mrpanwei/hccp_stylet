using System;
using Stylet;

namespace hccp.Pages
{
    public class ShellViewModel : Screen
    {
        public string Name { get; set; } = "jetaime";

        public void SayHello() => Name = "Hello " + Name;

        /// <summary>
        /// 注意这里的Can不是随意定义的，否则无效
        /// </summary>
        public bool CanSayHello => !string.IsNullOrEmpty(Name);
    }
}
