# Xamarin.Forms-Behaviors
Shows how to use Command instead of Click events (ItemTapped, ItemSelected...)

<ListView ItemsSource="{Binding Products}"
          SelectedItem="{Binding SelectedProduct}">
          <!--Instead of calling the SelectCommand from the code behind, we'll call it from the behavior-->
          <!--ItemSelected="ListView_ItemSelected"-->
            <ListView.Behaviors>
                <local:ItemSelectedToCommandBehavior Command="{Binding SelectCommand}" />
            </ListView.Behaviors>
</ListView>

<a href="https://www.youtube.com/watch?v=dzviFuEU09Y&t=90s">Here is a video demo on youtube: </a>

<a href="https://www.youtube.com/watch?v=dzviFuEU09Y&t=90s">
<img src="https://github.com/HoussemDellai/Xamarin.Forms-Behaviors/blob/master/XamarinFormsBehaviors/behaviors%201.jpg?raw=true"/>
</a>
