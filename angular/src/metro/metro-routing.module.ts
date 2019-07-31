import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MetroComponent } from './metro.component';
import { AppRouteGuard } from '@shared/auth/auth-route-guard';
import { HomeComponent } from './home/home.component';

// const routes: Routes = [{ path: '', component: MetroComponent }];

@NgModule({
  imports: [RouterModule.forChild([
    {
      path: '',
      component: MetroComponent,
      children: [
        { path: 'home', component: HomeComponent, canActivate: [AppRouteGuard] }
      ]
    }
  ])],
  exports: [RouterModule]
})
export class MetroRoutingModule { }
