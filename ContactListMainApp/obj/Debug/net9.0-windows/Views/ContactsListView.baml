   M S B A M L   `   `   `  ����M  IContactListMainApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ContactListMainApp.ViewsContactListMainApp.Views  5      M+clr-namespace:ContactListMainApp.ViewModelsContactListMainApp.ViewModels  5      C ?Business, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC/clr-namespace:Business.Models;assembly=BusinessBusiness.Models 5      +    %ContactListMainApp.Views.ContactsView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:ContactListMainApp.Views     5      B
viewmodels+clr-namespace:ContactListMainApp.ViewModels     5      Bmodels/clr-namespace:Business.Models;assembly=Business     5      
�������.��5      � $��10q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Contacts List��6!   $��Center=�66   $��20(�6S   $
��Bold"�6a   �� 5   
   $��1��6   $
��0 20q�6A   ��6    �� *
Contacts+��5      �� 5       �� DataType$ models:Contact��6   .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5       $
��Auto �6/   .+�5#      �� $��0��6%   $	��380��65   
�������.+�5$      �� $
��Bold"�6B    �� Padding$ 10 5 0 5q�6T   ��6(   �� *
FullName+6T   �� 5%      $
 10 0q�6E   ��6(   �� *ContactInfo+6E   �� 5&      $ 10 0 0 5q�6A   ��6(   �� *	Address+6A   5'      �� 5)      $��1��6%    �� Orientation$ 
Horizontal=�65   $��Right=�6N   .+�5*      �� $	����5,   %   $��Segoe MDL2 Assets)�68   $	��7 0q�6W   
����·���5*   %   �� *.+��5+   %   �� *$"DataContext.GoToDetailsViewCommand+ �� RelativeSource ��  �� AncestorType UserControl5,   e   5-      5/      50      52      �� 56   
   -   5        $��2��56      $��8q�6   $	��150��6*   $��Create New Contact��66   
��� ���$
��Bold"�6�   $��0,0,0,0q�6�    � Cursor$
 Hand��6�   ��6g   �� *GoToAddContactCommand+6�   58      59      