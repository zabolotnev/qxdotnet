using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using qxDotNet;

namespace qxDotNet.UI.Popup
{
    /// <summary>
    /// Popups are widgets, which can be placed on top of the application.
    /// They are automatically added to the application root.
    /// 
    /// Popups are used to display menus, the lists of combo or select boxes,
    /// tooltips, etc.
    /// 
    /// </summary>
    public partial class Popup : qxDotNet.UI.Container.Composite
    {

        private bool? _autoHide = true;
        private bool? _domMove = false;
        private int _offsetBottom = 0;
        private int _offsetLeft = 0;
        private int _offsetRight = 0;
        private int _offsetTop = 0;
        private qxDotNet.PlacementModeEnum _placementModeX = PlacementModeEnum.keep_align;
        private qxDotNet.PlacementModeEnum _placementModeY = PlacementModeEnum.keep_align;
        private qxDotNet.PlaceMethodEnum _placeMethod = PlaceMethodEnum.pointer;
        private qxDotNet.AlignmentEnum _position = AlignmentEnum.bottom_left;


        /// <summary>
        /// Whether to let the system decide when to hide the popup. Setting
        /// this to false gives you better control but it also requires you
        /// to handle the closing of the popup.
        /// 
        /// </summary>
        public bool? AutoHide
        {
            get
            {
                return _autoHide;
            }
            set
            {
               _autoHide = value;
            }
        }

        /// <summary>
        /// Whether the widget should moved using DOM methods.
        /// 
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
        /// Bottom offset of the pointer (in pixel)
        /// 
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
        /// Left offset of the pointer (in pixel)
        /// 
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
        /// Right offset of the pointer (in pixel)
        /// 
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
        /// Top offset of the pointer (in pixel)
        /// 
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
        /// Selects the algorithm to place the widget horizontally. direct
        /// uses {@link qx.util.placement.DirectAxis}, keep-align
        /// uses {@link qx.util.placement.KeepAlignAxis} and best-fit
        /// uses {@link qx.util.placement.BestFitAxis}.
        /// 
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
        /// Selects the algorithm to place the widget vertically. direct
        /// uses {@link qx.util.placement.DirectAxis}, keep-align
        /// uses {@link qx.util.placement.KeepAlignAxis} and best-fit
        /// uses {@link qx.util.placement.BestFitAxis}.
        /// 
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
        /// Whether the widget should be placed relative to an other widget or to
        /// the pointer.
        /// 
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
        /// Position of the aligned object in relation to the opener.
        /// 
        /// Please note than changes to this property are only applied
        /// when re-aligning the widget.
        /// 
        /// The first part of the value is the edge to attach to. The second
        /// part the alignment of the orthogonal edge after the widget
        /// has been attached.
        /// 
        /// The default value "bottom-left" for example means that the
        /// widget should be shown directly under the given target and
        /// then should be aligned to be left edge:
        /// 
        /// 
        /// +--------+
        /// | target |
        /// +--------+
        /// +-------------+
        /// | widget |
        /// +-------------+
        /// 
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
        /// Returns Qooxdoo type name for this type
        /// </summary>
        /// <returns>string</returns>
        protected internal override string GetTypeName()
        {
            return "qx.ui.popup.Popup";
        }

        /// <summary>
        /// Generates client code
        /// </summary>
        /// <param name="state">Serialized property values</param>
        internal override void Render(qxDotNet.Core.Object.PropertyBag state)
        {
            base.Render(state);
            state.SetPropertyValue("autoHide", _autoHide, true);
            state.SetPropertyValue("domMove", _domMove, false);
            state.SetPropertyValue("offsetBottom", _offsetBottom, 0);
            state.SetPropertyValue("offsetLeft", _offsetLeft, 0);
            state.SetPropertyValue("offsetRight", _offsetRight, 0);
            state.SetPropertyValue("offsetTop", _offsetTop, 0);
            state.SetPropertyValue("placementModeX", _placementModeX, PlacementModeEnum.keep_align);
            state.SetPropertyValue("placementModeY", _placementModeY, PlacementModeEnum.keep_align);
            state.SetPropertyValue("placeMethod", _placeMethod, PlaceMethodEnum.pointer);
            state.SetPropertyValue("position", _position, AlignmentEnum.bottom_left);


        }

        /// <summary>
        /// Dispatches client events
        /// </summary>
        /// <param name="eventName">Client event name</param>
        internal override void InvokeEvent(string eventName)
        {
            base.InvokeEvent(eventName);
        }

    }
}
