import { Component, OnInit, ViewEncapsulation, Injector } from '@angular/core';
import { MetroComponentBase } from '@shared/metro-component-base';
import { MenuItem } from '@shared/layout/menu-item';

@Component({
  selector: 'sidebar-nav',
  templateUrl: './sidebar-nav.component.html',
  encapsulation: ViewEncapsulation.None
})
export class SidebarNavComponent extends MetroComponentBase {
  menuItems: MenuItem[] = [
    new MenuItem(this.l('Home Page'), '', 'home', '/metro/home')
  ];
  constructor(injector: Injector) { super(injector); }
  showMenuItem(menuItem): boolean {
    if (menuItem.permissionName) {
      return this.permission.isGranted(menuItem.permissionName);
    }

    return true;
  }
}
