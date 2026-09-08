using UiPath.CodedWorkflows.DescriptorIntegration;

namespace asycutabot.ObjectRepository
{
    public static class Descriptors
    {
        public static class __ASYCUDAWorld
        {
            static string _reference = "KufmkzIlJkuDJlbts6D-4A/WlpPEQ1tjU2kDJwU6vM3Nw";
            public static _Implementation.___ASYCUDAWorld.__ASYCUDAWorld ASYCUDAWorld { get; private set; } = new _Implementation.___ASYCUDAWorld.__ASYCUDAWorld();
        }

        public static class __Chrome_New_Tab
        {
            static string _reference = "KufmkzIlJkuDJlbts6D-4A/4UaHeTfKWkWDMzdi3sOmbw";
            public static _Implementation.___Chrome_New_Tab.__Chrome_New_Tab Chrome_New_Tab { get; private set; } = new _Implementation.___Chrome_New_Tab.__Chrome_New_Tab();
        }

        public static class New_application_App
        {
            static string _reference = "KufmkzIlJkuDJlbts6D-4A/D3bvf-YjD0yLF-X1qlQF_w";
            public static _Implementation._New_application_App.__New_application New_application { get; private set; } = new _Implementation._New_application_App.__New_application();
            public static _Implementation._New_application_App.__New_application_1_ New_application_1_ { get; private set; } = new _Implementation._New_application_App.__New_application_1_();
        }

        public static class __Use_Application_
        {
            static string _reference = "KufmkzIlJkuDJlbts6D-4A/ITTlaZx3-ka2hLgQnsPMPw";
            public static _Implementation.___Use_Application_.__Use_Application_ Use_Application_ { get; private set; } = new _Implementation.___Use_Application_.__Use_Application_();
        }
    }
}

namespace asycutabot._Implementation
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

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class ___2026 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___2026(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/PPxX67I--k-Ptm04afkMBQ",
                    DisplayName = "2026",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Address_Desktop : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Address_Desktop(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/QJ5oeq18j0yAeTpSWJmbww",
                    DisplayName = "Address Desktop",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __All_locations_Desktop : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __All_locations_Desktop(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/PoRXOsMqykGFSKdeptcK5g",
                    DisplayName = "All locations Desktop",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __All_locations_Desktop_P_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __All_locations_Desktop_P_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/Vu4dCvy03UCfGjAkGOhNlg",
                    DisplayName = "All locations Desktop P…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Clearance_off_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Clearance_off_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/RJkQ_Y-OE0mKHvO7J4D-Zw",
                    DisplayName = "Clearance off.",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Click__forward_button_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__forward_button_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/RskGlKeJzkyu2K0DSGrHpg",
                    DisplayName = "Click 'forward button'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Click__push_button_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__push_button_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/sANKAT4xJEi8lZ-OeZbryg",
                    DisplayName = "Click 'push button'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Click_row_in_detailed_declaration : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click_row_in_detailed_declaration(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/IIpvLQraIkKE--8Zwg3gOQ",
                    DisplayName = "Click row in detailed declaration",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Close : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Close(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/5eSxpcfsZUGOgfVf-027bg",
                    DisplayName = "Close",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Close_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Close_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/3LRXOOOpKE-5uaQXWLQAJA",
                    DisplayName = "Close(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Close_2_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Close_2_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/S7qb1_UEakKPKH49Lc7NQg",
                    DisplayName = "Close(2)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Close_3_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Close_3_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/LJkITjVlUUmvtR29SPkfAQ",
                    DisplayName = "Close(3)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Close_4_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Close_4_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/xWZHCpH4FUSQJvUydaxZyQ",
                    DisplayName = "Close(4)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Detailed_Declaration : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Detailed_Declaration(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/h2dVDtr2HUGkvbJ7dhTj6Q",
                    DisplayName = "Detailed Declaration",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Edit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Edit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/9ExYZ37H8UCCeWHWhlU4LA",
                    DisplayName = "Edit",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Forward_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Forward_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/SsIv-KCUOkS7v1P5kzO4sg",
                    DisplayName = "Forward Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Iconify_Maximize_Close : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Iconify_Maximize_Close(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/NGfcP56etESU-kfV2QX1YQ",
                    DisplayName = "Iconify Maximize Close",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Keyboard_Shortcuts : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Keyboard_Shortcuts(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/AfpSOkYMI0Cn5477jl9sUQ",
                    DisplayName = "Keyboard Shortcuts",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __LC_Number : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LC_Number(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/zSgJ3gmY40eBDbnIZwTuyQ",
                    DisplayName = "LC Number",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __LC_Number_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LC_Number_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/bgNlE0pW_kykHmwPrxyYcg",
                    DisplayName = "LC Number(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __LC_Number_2_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LC_Number_2_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/M-d22e3zdUm5QIod1UwwIQ",
                    DisplayName = "LC Number(2)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Letter_of_Credit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Letter_of_Credit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/Ehauvtot8USGvIcM4UDyyA",
                    DisplayName = "Letter of Credit",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Print : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Print(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/pViiNGFkc0epvHVmD3k-hw",
                    DisplayName = "Print",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/gaYGcMMLW061GQFy_BljZQ",
                    DisplayName = "push button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/_KE-9_jmTEu6yCv8-6Zapw",
                    DisplayName = "push button(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_2_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_2_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/9BP_SyxY3kq4XJTkiePLuA",
                    DisplayName = "push button(2)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_3_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_3_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/ZF2XGL0OLkKUTzY9GYAJNw",
                    DisplayName = "push button(3)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_4_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_4_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/g0dz4FMzRkmb0ZD8JYxYXw",
                    DisplayName = "push button(4)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_5_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_5_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/GEhXvAx-xUuu5-t1pTroqw",
                    DisplayName = "push button(5)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_6_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_6_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/TXjPtnyn6k6UQqm8Xveeaw",
                    DisplayName = "push button(6)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_7_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_7_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/_xFdVM8D5Emq6rlSBRwiRg",
                    DisplayName = "push button(7)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __push_button_8_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __push_button_8_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/wl4T1zZtgU-1C8jAxW5lYA",
                    DisplayName = "push button(8)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Reg__Nber : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Reg__Nber(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/Gc7J28j8402K7fcbEhiYlg",
                    DisplayName = "Reg. Nber",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Reg__Ser_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Reg__Ser_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/wxD7asc96kiRX1OXn_TEog",
                    DisplayName = "Reg. Ser.",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Search_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Search_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/9A4RUKvk-kqAcm5f6Tuveg",
                    DisplayName = "Search Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __System : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __System(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/Z9lhqI7CQkKqk0wwLAo2tQ",
                    DisplayName = "System",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __table : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __table(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/zpEfgM5ryEOa2PujuxlI6w",
                    DisplayName = "table",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __table_1_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __table_1_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/G04PQqpXg0iy7ZOVyJVF3g",
                    DisplayName = "table(1)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __Write_off_Details : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Write_off_Details(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/r1MiZSTzukaeNp_qytQ0bw",
                    DisplayName = "Write off Details",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld._ASYCUDAWorld
    {
        public class __XXXXXXXX26060036 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __XXXXXXXX26060036(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/RYIv2l16Y0WQy-ZO9iWoxQ",
                    DisplayName = "XXXXXXXX26060036",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___ASYCUDAWorld
    {
        public class __ASYCUDAWorld : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __ASYCUDAWorld()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/ZPJNQ8Vc-UaAYhjNZoIlhg",
                    DisplayName = "ASYCUDAWorld",
                    Screen = this
                };
                _2026 = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.___2026(this, null);
                Address_Desktop = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Address_Desktop(this, null);
                All_locations_Desktop = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__All_locations_Desktop(this, null);
                All_locations_Desktop_P_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__All_locations_Desktop_P_(this, null);
                Clearance_off_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Clearance_off_(this, null);
                Click__forward_button_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click__forward_button_(this, null);
                Click__push_button_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click__push_button_(this, null);
                Click_row_in_detailed_declaration = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click_row_in_detailed_declaration(this, null);
                Close = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close(this, null);
                Close_1_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_1_(this, null);
                Close_2_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_2_(this, null);
                Close_3_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_3_(this, null);
                Close_4_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_4_(this, null);
                Detailed_Declaration = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Detailed_Declaration(this, null);
                Edit = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Edit(this, null);
                Forward_Button = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Forward_Button(this, null);
                Iconify_Maximize_Close = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Iconify_Maximize_Close(this, null);
                Keyboard_Shortcuts = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Keyboard_Shortcuts(this, null);
                LC_Number = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number(this, null);
                LC_Number_1_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number_1_(this, null);
                LC_Number_2_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number_2_(this, null);
                Letter_of_Credit = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Letter_of_Credit(this, null);
                Print = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Print(this, null);
                push_button = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button(this, null);
                push_button_1_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_1_(this, null);
                push_button_2_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_2_(this, null);
                push_button_3_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_3_(this, null);
                push_button_4_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_4_(this, null);
                push_button_5_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_5_(this, null);
                push_button_6_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_6_(this, null);
                push_button_7_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_7_(this, null);
                push_button_8_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_8_(this, null);
                Reg__Nber = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Reg__Nber(this, null);
                Reg__Ser_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Reg__Ser_(this, null);
                Search_Button = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Search_Button(this, null);
                System = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__System(this, null);
                table = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__table(this, null);
                table_1_ = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__table_1_(this, null);
                Write_off_Details = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Write_off_Details(this, null);
                XXXXXXXX26060036 = new _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__XXXXXXXX26060036(this, null);
            }

            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.___2026 _2026 { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Address_Desktop Address_Desktop { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__All_locations_Desktop All_locations_Desktop { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__All_locations_Desktop_P_ All_locations_Desktop_P_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Clearance_off_ Clearance_off_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click__forward_button_ Click__forward_button_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click__push_button_ Click__push_button_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Click_row_in_detailed_declaration Click_row_in_detailed_declaration { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close Close { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_1_ Close_1_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_2_ Close_2_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_3_ Close_3_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Close_4_ Close_4_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Detailed_Declaration Detailed_Declaration { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Edit Edit { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Forward_Button Forward_Button { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Iconify_Maximize_Close Iconify_Maximize_Close { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Keyboard_Shortcuts Keyboard_Shortcuts { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number LC_Number { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number_1_ LC_Number_1_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__LC_Number_2_ LC_Number_2_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Letter_of_Credit Letter_of_Credit { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Print Print { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button push_button { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_1_ push_button_1_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_2_ push_button_2_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_3_ push_button_3_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_4_ push_button_4_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_5_ push_button_5_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_6_ push_button_6_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_7_ push_button_7_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__push_button_8_ push_button_8_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Reg__Nber Reg__Nber { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Reg__Ser_ Reg__Ser_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Search_Button Search_Button { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__System System { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__table table { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__table_1_ table_1_ { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__Write_off_Details Write_off_Details { get; private set; }
            public _Implementation.___ASYCUDAWorld._ASYCUDAWorld.__XXXXXXXX26060036 XXXXXXXX26060036 { get; private set; }
        }
    }

    namespace ___Chrome_New_Tab._Chrome_New_Tab
    {
        public class __editable_text_Address_a_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __editable_text_Address_a_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/enh4N1iRKkKu1TCD9mKN7g",
                    DisplayName = "editable text Address a…",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace ___Chrome_New_Tab
    {
        public class __Chrome_New_Tab : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_New_Tab()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/ktLirJl19UWGTFcy2W434Q",
                    DisplayName = "Chrome New Tab",
                    Screen = this
                };
                editable_text_Address_a_ = new _Implementation.___Chrome_New_Tab._Chrome_New_Tab.__editable_text_Address_a_(this, null);
            }

            public _Implementation.___Chrome_New_Tab._Chrome_New_Tab.__editable_text_Address_a_ editable_text_Address_a_ { get; private set; }
        }
    }

    namespace _New_application_App._New_application
    {
        public class __Click__push_button_7__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__push_button_7__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/UKye_c_dEUW8pHK2Ge-_hA",
                    DisplayName = "Click 'push button(7)'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _New_application_App
    {
        public class __New_application : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __New_application()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/4d-YO6cHn0uhve1CY9_4cg",
                    DisplayName = "New application",
                    Screen = this
                };
                Click__push_button_7__ = new _Implementation._New_application_App._New_application.__Click__push_button_7__(this, null);
            }

            public _Implementation._New_application_App._New_application.__Click__push_button_7__ Click__push_button_7__ { get; private set; }
        }
    }

    namespace _New_application_App._New_application_1_
    {
        public class __Click__print_Button_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__print_Button_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/4CZYqYbIf0SxwDP0faI4BA",
                    DisplayName = "Click 'print Button'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _New_application_App
    {
        public class __New_application_1_ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __New_application_1_()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/dF3WEhGAekOJuA6Kf1B8mw",
                    DisplayName = "New application(1)",
                    Screen = this
                };
                Click__print_Button_ = new _Implementation._New_application_App._New_application_1_.__Click__print_Button_(this, null);
            }

            public _Implementation._New_application_App._New_application_1_.__Click__print_Button_ Click__print_Button_ { get; private set; }
        }
    }

    namespace ___Use_Application_
    {
        public class __Use_Application_ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Use_Application_()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "KufmkzIlJkuDJlbts6D-4A/rXlqVwV0BUO6FRpey0vI4A",
                    DisplayName = "Use Application ",
                    Screen = this
                };
            }
        }
    }
}