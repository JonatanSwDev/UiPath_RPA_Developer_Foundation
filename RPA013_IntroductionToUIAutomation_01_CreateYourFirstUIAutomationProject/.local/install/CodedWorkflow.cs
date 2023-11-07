using System;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace RPA013_IntroductionToUIAutomation_01_CreateYourFirstUIAutomationProject
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace RPA013_IntroductionToUIAutomation_01_CreateYourFirstUIAutomationProject.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace RPA013_IntroductionToUIAutomation_01_CreateYourFirstUIAutomationProject._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }
}