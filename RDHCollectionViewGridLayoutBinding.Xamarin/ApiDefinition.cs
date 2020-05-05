using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace RDH
{
    // @interface RDHCollectionViewGridLayout : UICollectionViewLayout
    [BaseType(typeof(UICollectionViewLayout))]
    interface RDHCollectionViewGridLayout
    {
        // @property (assign, nonatomic) UICollectionViewScrollDirection scrollDirection;
        [Export("scrollDirection", ArgumentSemantic.Assign)]
        UICollectionViewScrollDirection ScrollDirection { get; set; }

        // @property (assign, nonatomic) CGFloat lineSize;
        [Export("lineSize")]
        nfloat LineSize { get; set; }

        // @property (assign, nonatomic) CGFloat lineMultiplier;
        [Export("lineMultiplier")]
        nfloat LineMultiplier { get; set; }

        // @property (assign, nonatomic) CGFloat lineExtension;
        [Export("lineExtension")]
        nfloat LineExtension { get; set; }

        // @property (assign, nonatomic) NSUInteger lineItemCount;
        [Export("lineItemCount")]
        nuint LineItemCount { get; set; }

        // @property (assign, nonatomic) CGFloat itemSpacing;
        [Export("itemSpacing")]
        nfloat ItemSpacing { get; set; }

        // @property (assign, nonatomic) CGFloat lineSpacing;
        [Export("lineSpacing")]
        nfloat LineSpacing { get; set; }

        // @property (assign, nonatomic) BOOL sectionsStartOnNewLine;
        [Export("sectionsStartOnNewLine")]
        bool SectionsStartOnNewLine { get; set; }
    }

    // @interface RDHCollectionViewGridLayout_Deprecated (RDHCollectionViewGridLayout)
    [Category]
    interface RDHCollectionViewGridLayout_RDHCollectionViewGridLayout_Deprecated
    {
        // @property (assign, nonatomic) CGFloat lineDimension __attribute__((deprecated("use lineSize instead.")));
        [Export("lineDimension")]
        nfloat LineDimension { get; set; }
    }
}

