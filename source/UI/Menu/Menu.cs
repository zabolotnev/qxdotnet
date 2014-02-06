using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Menu
{
    /// <summary>
    /// The menu is a popup like control which supports buttons. It comes with full keyboard navigation and an improved timeout based mouse control behavior.  This class is the container for all derived instances of {@link qx.ui.menu.AbstractButton}.
    /// </summary>
    public partial class Menu : qxDotNet.UI.Core.Widget
    {

        private int _arrowColumnWidth = 0;
        private bool? _blockBackground = false;
        private string _blockerColor = null;
        private decimal _blockerOpacity = 1m;
        private int _closeInterval = 250;
        private int _iconColumnWidth = 0;
        private qxDotNet.UI.Core.Widget _openedButton = null;
        private qxDotNet.UI.Core.Widget _opener = null;
        private int _openInterval = 250;
        private qxDotNet.UI.Core.Widget _selectedButton = null;
        private int _spacingX = 0;
        private int _spacingY = 0;
        private bool? _domMove = false;
        private int _offsetBottom = 0;
        private int _offsetLeft = 0;
        private int _offsetRight = 0;
        private int _offsetTop = 0;
        private qxDotNet.PlacementModeEnum _placementModeX = PlacementModeEnum.keep_align;
        private qxDotNet.PlacementModeEnum _placementModeY = PlacementModeEnum.keep_align;
        private qxDotNet.PlaceMethodEnum _placeMethod = PlaceMethodEnum.mouse;
        private qxDotNet.AlignmentEnum _position = AlignmentEnum.bottom_left;


        /// <summary>
        /// Default arrow column width if no sub menus are rendered
        /// </summary>
        public int ArrowColumnWidth
        {
            get
            {
                return _arrowColumnWidth;
            }
            set
            {
               _arrowColumnWidth = value;
            }
        }

        /// <summary>
        /// Blocks the background if value is true
        /// </summary>
        public bool? BlockBackground
        {
            get
            {
                return _blockBackground;
            }
            set
            {
               _blockBackground = value;
            }
        }

        /// <summary>
        /// Color of the blocker
        /// </summary>
        public string BlockerColor
        {
            get
            {
                return _blockerColor;
            }
            set
            {
               _blockerColor = value;
            }
        }

        /// <summary>
        /// Opacity of the blocker
        /// </summary>
        public decimal BlockerOpacity
        {
            get
            {
                return _blockerOpacity;
            }
            set
            {
               _blockerOpacity = value;
            }
        }

        /// <summary>
        /// Interval in ms after which sub menus should be closed
        /// </summary>
        public int CloseInterval
        {
            get
            {
                return _closeInterval;
            }
            set
            {
               _closeInterval = value;
            }
        }

        /// <summary>
        /// Default icon column width if no icons are rendered. This property is ignored as soon as an icon is present.
        /// </summary>
        public int IconColumnWidth
        {
            get
            {
                return _iconColumnWidth;
            }
            set
            {
               _iconColumnWidth = value;
            }
        }

        /// <summary>
        /// The currently opened button (sub menu is visible)
        /// </summary>
        public qxDotNet.UI.Core.Widget OpenedButton
        {
            get
            {
                return _openedButton;
            }
            set
            {
               _openedButton = value;
            }
        }

        /// <summary>
        /// Widget that opened the menu
        /// </summary>
        public qxDotNet.UI.Core.Widget Opener
        {
            get
            {
                return _opener;
            }
            set
            {
               _opener = value;
            }
        }

        /// <summary>
        /// Interval in ms after which sub menus should be opened
        /// </summary>
        public int OpenInterval
        {
            get
            {
                return _openInterval;
            }
            set
            {
               _openInterval = value;
            }
        }

        /// <summary>
        /// The currently selected button
        /// </summary>
        public qxDotNet.UI.Core.Widget SelectedButton
        {
            get
            {
                return _selectedButton;
            }
            set
            {
               _selectedButton = value;
            }
        }

        /// <summary>
        /// The spacing between each cell of the menu buttons
        /// </summary>
        public int SpacingX
        {
            get
            {
                return _spacingX;
            }
            set
            {
               _spacingX = value;
            }
        }

        /// <summary>
        /// The spacing between each menu button
        /// </summary>
        public int SpacingY
        {
            get
            {
                return _spacingY;
            }
            set
            {
               _spacingY = value;
            }
        }

        /// <summary>
        /// Whether the widget should moved using DOM methods.
        /// </summary>
        public bool? DomMove
        {
            get
            {
                return _domMove;
            }
            set
            {
               _domMove = value;
            }
        }

        /// <summary>
        /// Bottom offset of the mouse pointer (in pixel)
        /// </summary>
        public int OffsetBottom
        {
            get
            {
                return _offsetBottom;
            }
            set
            {
               _offsetBottom = value;
            }
        }

        /// <summary>
        /// Left offset of the mouse pointer (in pixel)
        /// </summary>
        public int OffsetLeft
        {
            get
            {
                return _offsetLeft;
            }
            set
            {
               _offsetLeft = value;
            }
        }

        /// <summary>
        /// Right offset of the mouse pointer (in pixel)
        /// </summary>
        public int OffsetRight
        {
            get
            {
                return _offsetRight;
            }
            set
            {
               _offsetRight = value;
            }
        }

        /// <summary>
        /// Top offset of the mouse pointer (in pixel)
        /// </summary>
        public int OffsetTop
        {
            get
            {
                return _offsetTop;
            }
            set
            {
               _offsetTop = value;
            }
        }

        /// <summary>
        /// Selects the algorithm to place the widget horizontally. direct uses {@link qx.util.placement.DirectAxis}, keep-align uses {@link qx.util.placement.KeepAlignAxis} and best-fit uses {@link qx.util.placement.BestFitAxis}.
        /// </summary>
        public qxDotNet.PlacementModeEnum PlacementModeX
        {
            get
            {
                return _placementModeX;
            }
            set
            {
               _placementModeX = value;
            }
        }

        /// <summary>
        /// Selects the algorithm to place the widget vertically. direct uses {@link qx.util.placement.DirectAxis}, keep-align uses {@link qx.util.placement.KeepAlignAxis} and best-fit uses {@link qx.util.placement.BestFitAxis}.
        /// </summary>
        public qxDotNet.PlacementModeEnum PlacementModeY
        {
            get
            {
                return _placementModeY;
            }
            set
            {
               _placementModeY = value;
            }
        }

        /// <summary>
        /// Whether the widget should be placed relative to an other widget or to the mouse cursor.
        /// </summary>
        public qxDotNet.PlaceMethodEnum PlaceMethod
        {
            get
            {
                return _placeMethod;
            }
            set
            {
               _placeMethod = value;
            }
        }

        /// <summary>
        /// Position of the aligned object in relation to the opener.  Please note than changes to this property are only applied when re-aligning the widget.  The first part of the value is the edge to attach to. The second part the alignment of the orthogonal edge after the widget has been attached.  The default value "bottom-left" for example means that the widget should be shown directly under the given target and then should be aligned to be left edge:   +--------+ | target | +--------+ +-------------+ | widget | +-------------+ 
        /// </summary>
        public qxDotNet.AlignmentEnum Position
        {
            get
            {
                return _position;
            }
            set
            {
               _position = value;
            }
        }

        /// <summary>
        /// Internal implementation
        /// </summary>
        /// <returns></returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.menu.Menu";
        }

        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("arrowColumnWidth", _arrowColumnWidth, 0);
            state.SetPropertyValue("blockBackground", _blockBackground, false);
            state.SetPropertyValue("blockerColor", _blockerColor, null);
            state.SetPropertyValue("blockerOpacity", _blockerOpacity, 1m);
            state.SetPropertyValue("closeInterval", _closeInterval, 250);
            state.SetPropertyValue("iconColumnWidth", _iconColumnWidth, 0);
            state.SetPropertyValue("openedButton", _openedButton, null);
            state.SetPropertyValue("opener", _opener, null);
            state.SetPropertyValue("openInterval", _openInterval, 250);
            state.SetPropertyValue("selectedButton", _selectedButton, null);
            state.SetPropertyValue("spacingX", _spacingX, 0);
            state.SetPropertyValue("spacingY", _spacingY, 0);
            state.SetPropertyValue("domMove", _domMove, false);
            state.SetPropertyValue("offsetBottom", _offsetBottom, 0);
            state.SetPropertyValue("offsetLeft", _offsetLeft, 0);
            state.SetPropertyValue("offsetRight", _offsetRight, 0);
            state.SetPropertyValue("offsetTop", _offsetTop, 0);
            state.SetPropertyValue("placementModeX", _placementModeX, PlacementModeEnum.keep_align);
            state.SetPropertyValue("placementModeY", _placementModeY, PlacementModeEnum.keep_align);
            state.SetPropertyValue("placeMethod", _placeMethod, PlaceMethodEnum.mouse);
            state.SetPropertyValue("position", _position, AlignmentEnum.bottom_left);


        }

        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
