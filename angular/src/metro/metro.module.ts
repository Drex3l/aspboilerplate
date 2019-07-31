import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MetroRoutingModule } from './metro-routing.module';
import { MetroComponent } from './metro.component';
import { HomeComponent } from './home/home.component';
import { HeaderMobileComponent } from './layout/header-mobile.component';
import { SidebarNavComponent } from './layout/sidebar-nav.component';
import { TopBarComponent } from './layout/top-bar.component';


@NgModule({
  declarations: [
    MetroComponent,
    HomeComponent,
    HeaderMobileComponent,
    SidebarNavComponent,
    TopBarComponent
  ],
  imports: [
    CommonModule,
    MetroRoutingModule
  ]
})
export class MetroModule { }
