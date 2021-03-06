using System;
using Windows.UI.Xaml;

namespace Xamarin.Forms.Platform.UWP
{
	internal static class AlignmentExtensions
	{
		internal static Windows.UI.Xaml.TextAlignment ToNativeTextAlignment(this TextAlignment alignment, EffectiveFlowDirection flowDirection = default(EffectiveFlowDirection))
		{
			var isLtr = flowDirection.IsLeftToRight();
			switch (alignment)
			{
				case TextAlignment.Justify:
					return Windows.UI.Xaml.TextAlignment.Justify;
				case TextAlignment.Center:
					return Windows.UI.Xaml.TextAlignment.Center;
				case TextAlignment.End:
					if (isLtr)
						return Windows.UI.Xaml.TextAlignment.Right;
					else
						return Windows.UI.Xaml.TextAlignment.Left;
				default:
					if (isLtr)
						return Windows.UI.Xaml.TextAlignment.Left;
					else
						return Windows.UI.Xaml.TextAlignment.Right;
			}
		}

		internal static VerticalAlignment ToNativeVerticalAlignment(this TextAlignment alignment)
		{
			switch (alignment)
			{
				case TextAlignment.Justify:
					throw new NotSupportedException("Justify is not supported for vertical alignment");
				case TextAlignment.Center:
					return VerticalAlignment.Center;
				case TextAlignment.End:
					return VerticalAlignment.Bottom;
				default:
					return VerticalAlignment.Top;
			}
		}

		internal static HorizontalAlignment ToNativeHorizontalAlignment(this TextAlignment alignment)
		{
			switch (alignment)
			{
				case TextAlignment.Center:
					return HorizontalAlignment.Center;
				case TextAlignment.End:
					return HorizontalAlignment.Right;
				default:
					return HorizontalAlignment.Left;
			}
		}
	}
}