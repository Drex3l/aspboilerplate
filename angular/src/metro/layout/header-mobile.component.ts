import { Component, ViewEncapsulation, Injector } from '@angular/core';
import { MetroComponentBase } from '@shared/metro-component-base';

@Component({
  selector: 'header-mobile',
  templateUrl: './header-mobile.component.html',
  encapsulation: ViewEncapsulation.None
})
export class HeaderMobileComponent extends MetroComponentBase {

  constructor(injector: Injector) { super(injector); }

}
