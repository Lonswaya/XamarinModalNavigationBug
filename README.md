# XamarinModalNavigationBug

Related to https://github.com/xamarin/Xamarin.Forms/issues/11461

NavigableElement.Navigation seems to ignore the NavigationStack, returning only an empty array, despite what may exist prior to a modal page. This only seems to happen when pushing the content page as a modal page. 

<image src=Screenshot.PNG>

