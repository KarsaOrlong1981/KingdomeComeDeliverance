

namespace KingdomeComeDeliverance.Controls
{
    /// <summary>
    /// A view that renders its content based on a data template. Typical usage is to either set an explicit 
    /// <see cref="BindableObject.BindingContext"/> on this element or use an inhereted one, then set a display.
    /// </summary>
    public class ContentControl : ContentView
    {
        /// <summary>
        /// The content template property
        /// </summary>
        public static readonly BindableProperty ContentTemplateProperty = BindableProperty.Create(nameof(ContentTemplate), typeof(DataTemplate), typeof(ContentControl));

        protected override void OnBindingContextChanged()
        {
            var template = ContentTemplate;
            if (template == null)
            {
                return;
            }
            if (template is DataTemplateSelector dataTemplateSelector)
            {
                var item = GetValue(BindingContextProperty);
                template = dataTemplateSelector.SelectTemplate(item, this);
            }
            Content = (View)template?.CreateContent();
        }

        /// <summary>
        /// A <see cref="DataTemplate"/> used to render the view. This property is bindable.
        /// </summary>
        public DataTemplate ContentTemplate
        {
            get
            {
                return (DataTemplate)GetValue(ContentTemplateProperty);
            }
            set
            {
                SetValue(ContentTemplateProperty, value);
            }
        }

    }
}
