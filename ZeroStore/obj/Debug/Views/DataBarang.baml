   M S B A M L   `   `   `  ????D  @ZeroStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZeroStore.ViewsZeroStore.Views  5      ;"clr-namespace:ZeroStore.ViewModelsZeroStore.ViewModels  5           ZeroStore.Views.DataBarang   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ZeroStore.Views     5      9
viewmodels"clr-namespace:ZeroStore.ViewModels     5        N? Title$  
DataBarang??5
      .??5      ? ???#F2E7D5 ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??Data Barang??6   $??0??5      $??0??5      $??2??5      $??20(?5      $
??Bold"?5       $??Center=?5!      $	??5,8q?61   &   System.Windows.Controls.DataGrid  5"   
   -   5        $??dgProduk??5"         AutoGenerateColumns .  $??6??5$      $??Center=?5%      $??3q?5&      $??2??6S   ??6   ??  ?? Path$ 
BarangList? ?? Mode$ TwoWay=?   Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Barang Id??5)         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5*      ?? $ Id?
   HeaderStyle
 5+      ?? 5,       ?? 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .?5-      ??  ?? Property ? ?? ?? Value$ Center=?6K   5.      50        51      $ Nama Barang??52      $	 100 6*   	 53      ?? $ 
Namebarang?
 54      ?? 55      "  6    .?56      ??  ? ??$ Center=?6K   57      59        5:      $ Status Barang??5;      $	 100 6,   	 5<      ?? $ Statusbarang?
 5=      ?? 5>      "  6    .?5?      ??  ? ??$ Center=?6K   5@      5B        5C      $ Id Harga??5D      $	 100 6'   	 5E      ?? $ Id_harga?
 5F      ?? 5G      "  6    .?5H      ??  ? ??$ Center=?6K   5I      5K        5L      $ 	Id Barang??5M      $	 100 6(   	 5N      ?? $ Id?
 5O      ?? 5P      "  6    .?5Q      ??  ? ??$ Center=?6K   5R      5T        5U      $ Harga Barang??5V      $	 100 6+   	 5W      ?? $ hargabarang?
 5X      ?? 5Y      "  6    .?5Z      ??  ? ??$ Center=?6K   5[      5]      5_      5`      5a      