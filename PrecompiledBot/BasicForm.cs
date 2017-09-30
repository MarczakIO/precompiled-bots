using System;
using Microsoft.Bot.Builder.FormFlow;

namespace PrecompiledBot
{
    public enum MobileOptions { Smartphone = 1, Smartwatch, Laptop, Tablet };
    public enum ColorOptions { Gray = 1, Gold, White, Silver, Other };

    // For more information about this template visit http://aka.ms/azurebots-csharp-form
    [Serializable]
    public class BasicForm
    {
        [Prompt("Please type in your {&}")]
        public string Name { get; set; }

        [Prompt("Please select your favorite mobile device {||}")]
        public MobileOptions Car { get; set; }

        [Prompt("Please select your favorite {&} {||}")]
        public ColorOptions Color { get; set; }

        public static IForm<BasicForm> BuildForm()
        {
            // Builds an IForm<T> based on BasicForm
            return new FormBuilder<BasicForm>().Build();
        }

        public static IFormDialog<BasicForm> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
        {
            // Generated a new FormDialog<T> based on IForm<BasicForm>
            return FormDialog.FromForm(BuildForm, options);
        }
    }

}
