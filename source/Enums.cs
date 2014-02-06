using System;

namespace qxDotNet
{

    public enum DecorationEnum
    {
        @null=-1, underline, line_through, overline
    }
    public enum StateEnum
    {
        created,configured,queued,sending,receiving,completed,aborted,timeout,failed
    }
    public enum AlignmentEnum
    {
        top_left,top_right,bottom_left,bottom_right,center
    }
    public enum OrientationEnum
    {
        horizontal,vertical
    }
    public enum PositionEnum
    {
        relative,absolute
    }
    public enum MethodEnum
    {
        GET,POST,PUT,HEAD,DELETE
    }
    public enum IconPositionEnum
    {
        top,right,bottom,left,top_left,bottom_left,top_right,bottom_right
    }
    public enum ShowEnum
    {
        both,label,icon
    }
    public enum TextAlignEnum
    {
        @null=-1, left, center, right, justify
    }
    public enum ActionEnum
    {
        alias,copy,move
    }
    public enum PlacementModeEnum
    {
        direct,keep_align,best_fit
    }
    public enum PlaceMethodEnum
    {
        widget,mouse
    }
    public enum AlignXEnum
    {
        left,center,right
    }
    public enum AlignYEnum
    {
        top,middle,bottom,baseline
    }
    public enum SelectionModeEnum
    {
        single,multi,additive,one
    }
    public enum OverflowEnum
    {
        hidden,visible,scroll,auto
    }
    public enum ScrollbarEnum
    {
        @null=-1,auto,on,off,yes,no
    }
    public enum ModeEnum
    {
        single,multi,additive,one
    }
    public enum VisibilityEnum
    {
        visible,hidden,excluded
    }
    public enum ColorPositionUnitEnum
    {
        px,percent
    }
    public enum BorderImageModeEnum
    {
        horizontal,vertical,grid
    }
    public enum RepeatEnum
    {
        stretch,repeat,round
    }
    public enum BackgroundRepeatEnum
    {
        repeat,repeat_x,repeat_y,no_repeat,scale
    }
    public enum StyleEnum
    {
        solid,dotted,dashed,@double,inset,outset,ridge,groove
    }
    public enum AllowScriptAccessEnum
    {
        sameDomain,always,never
    }
    public enum QualityEnum
    {
        low,autolow,autohigh,medium,high,best
    }
    public enum ScaleEnum
    {
        showall,noborder,exactfit,noscale
    }
    public enum WmodeEnum
    {
        window,opaque,transparent
    }
    public enum LegendPositionEnum
    {
        top,middle
    }
    public enum SortEnum
    {
        auto,y,x
    }
    public enum PositionZEnum
    {
        above,below
    }
    public enum TransformUnitEnum
    {
        rem,px
    }
    public enum DisplayValueEnum
    {
        value,percent
    }
    public enum BarPositionEnum
    {
        left,right,top,bottom
    }
    public enum ArrowPositionEnum
    {
        left,right
    }
    public enum OpenSymbolModeEnum
    {
        always,never,auto
    }
    public enum OpenModeEnum
    {
        click,dblclick,none
    }
    public enum AlignEnum
    {
        top,right,bottom,left,center,middle
    }
    public enum EdgeEnum
    {
        top,right,bottom,left
    }
    public enum TableSelectionModelEnum
    {
        NO_SELECTION = 1,
        SINGLE_SELECTION = 2,
        SINGLE_INTERVAL_SELECTION = 3,
        MULTIPLE_INTERVAL_SELECTION = 4,
        MULTIPLE_INTERVAL_SELECTION_TOGGLE = 5
    }
}
