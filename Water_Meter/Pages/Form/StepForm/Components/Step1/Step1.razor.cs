using AntDesign;
using Microsoft.AspNetCore.Components;
using Water_Meter.Models;

namespace Water_Meter.Pages.Form
{
    public partial class Step1
    {
        private readonly StepFormModel _model = new StepFormModel();
        private readonly FormItemLayout _formLayout = new FormItemLayout
        {
            WrapperCol = new ColLayoutParam
            {
                Xs = new EmbeddedProperty { Span = 24, Offset = 0 },
                Sm = new EmbeddedProperty { Span = 19, Offset = 5 },
            }
        };

        [CascadingParameter] public StepForm StepForm { get; set; }

        public void OnValidateForm()
        {
            StepForm.Next();
        }
    }
}