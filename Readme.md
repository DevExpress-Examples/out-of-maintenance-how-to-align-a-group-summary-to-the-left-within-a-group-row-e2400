<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128648066/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2400)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/LeftAlignSummary/Window1.xaml) (VB: [Window1.xaml](./VB/LeftAlignSummary/Window1.xaml))
* [Window1.xaml.cs](./CS/LeftAlignSummary/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/LeftAlignSummary/Window1.xaml.vb))
<!-- default file list end -->
# How to align a group summary to the left within a group row


<p>Let's imagine a grouped grid with several <a href="http://documentation.devexpress.com/#WPF/CustomDocument6127">summaries</a> displayed within <a href="http://documentation.devexpress.com/#WPF/CustomDocument6185">group rows</a>. There is a need to display the Count summary next to the group row text, while other summaries remain right-aligned. This example demonstrates a way of accomplishing this task.</p><p>Since group summaries are stacked to the right side, moving a particular summary value to the left may be tricky. It's required to add this particular summary to the group row text and also remove it from the summary stack. Otherwise, the same summary will be displayed twice. In our example, we use <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_GroupValueTemplatetopic">GroupValueTemplate</a> to append summary text to group row text. To remove the summary, a custom <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_GroupSummaryItemTemplateSelectortopic">GroupSummaryItemTemplateSelector</a> is defined.</p><p><strong>See Also:</strong><br />
<a href="http://documentation.devexpress.com/#WPF/CustomDocument6677">Choosing Templates Based on Custom Logic</a></p>

<br/>


