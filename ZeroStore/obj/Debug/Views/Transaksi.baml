   M S B A M L   `   `   `  ????D  @ZeroStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZeroStore.ViewsZeroStore.Views  5      ;"clr-namespace:ZeroStore.ViewModelsZeroStore.ViewModels  5          ZeroStore.Views.Transaksi   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ZeroStore.Views     5      9
viewmodels"clr-namespace:ZeroStore.ViewModels     5        N? Title$  	Transaksi??5
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
   ?? $??Data Transaksi??6   $??0??5      $??0??5      $??2??5      $??20(?5      $
??Bold"?5       $??Center=?5!      $	??5,8q?61   ?? 5"   
   -   5        $??Export Data??5"      $??1??5#      $??0??5$      $??1??5%      $??7q?5&      $??
10,1,10,10q?5'      ???#D8CBAC$??50??6O   $??30??6]   $
??Bold"?6i    ? 	Resources 5(       ?? 
TargetType ?? Property ?? Value??%^   '??       ?? 5)      " ??6   .?5*      ??  ?@??CornerRadius$ 7??65   5+      5,      5-      &   System.Windows.Controls.DataGrid  5.   
   -   5        $??dgTransaksi??5.         AutoGenerateColumns .  $??6??50      $??Center=?51      $??3q?52      $??2??6V   ??6   ??  ?? Path$ TransaksiList?	 ?? Mode$	 TwoWay=?
   Columns
 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Konsumen Id??55         Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6+   1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      ?? $ Id_konsumen?   HeaderStyle 57      ?? 58      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .?59      ??  ? ??$ Center=?6K   5:      5<        5=      $ Nama Konsumen??5>      $	 100 6,    5?      ?? $ Nama_konsumen? 5@      ?? 5A      "  6    .?5B      ??  ? ??$ Center=?6K   5C      5E        5F      $ Alamat Konsumen??5G      $	 100 6.    5H      ?? $ Alamat_konsumen? 5I      ?? 5J      "  6    .?5K      ??  ? ??$ Center=?6K   5L      5N        5O      $ Id Transaksi??5P      $	 100 6+    5Q      ?? $ Id_transaksi? 5R      ?? 5S      "  6    .?5T      ??  ? ??$ Center=?6K   5U      5W        5X      $ 	Id Barang??5Y      $	 100 6(    5Z      ?? $ Id? 5[      ?? 5\      "  6    .?5]      ??  ? ??$ Center=?6K   5^      5`        5a      $ Id Konsumen??5b      $	 100 6*    5c      ?? $ Id_konsumen? 5d      ?? 5e      "  6    .?5f      ??  ? ??$ Center=?6K   5g      5i        5j      $ tanggal??5k      $	 100 6&    5l      ?? $ tanggal? 5m      ?? 5n      "  6    .?5o      ??  ? ??$ Center=?6K   5p      5r        5s      $ 
Keterangan??5t      $	 100 6)    5u      ?? $ 
keterangan? 5v      ?? 5w      "  6    .?5x      ??  ? ??$ Center=?6K   5y      5{      5}      5~      5      