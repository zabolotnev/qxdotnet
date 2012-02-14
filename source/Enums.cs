using System;

namespace qxDotNet
{

    public enum DecorationEnum
    {
        underline,line_through,overline
    }
    public enum StateEnum
    {
        created,configured,queued,sending,receiving,completed,aborted,timeout,failed
    }
    public enum TransitionEnum
    {
        linear,easeInQuad,easeOutQuad,sinodial,reverse,flicker,wobble,pulse,spring,none,full
    }
    public enum DirectionEnum
    {
        south,west,east,north,south_west,south_east,north_east,north_west
    }
    public enum ModeEnum
    {
        @in,@out
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
        top,right,bottom,left,top_left,bottom_left
    }
    public enum ShowEnum
    {
        both,label,icon
    }
    public enum TextAlignEnum
    {
        @null,left,center,right,justify
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
        auto,on,off
    }
    public enum VisibilityEnum
    {
        visible,hidden,excluded
    }
    public enum BackgroundRepeatEnum
    {
        repeat,repeat_x,repeat_y,no_repeat,scale
    }
    public enum RepeatEnum
    {
        stretch,repeat,round
    }
    public enum StyleEnum
    {
        solid,dotted,dashed,@double
    }
    public enum ColorPositionUnitEnum
    {
        px,percent
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
    public enum ScrollbarVisibleEnum
    {
        auto,no,yes
    }
    public enum LegendPositionEnum
    {
        top,middle
    }
    public enum SortEnum
    {
        auto,y,x
    }
    public enum BarPositionEnum
    {
        left,right,top,bottom
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
        top,right,bottom,left
    }
    public enum EdgeEnum
    {
        top,right,bottom,left
    }
}
