import { Component, ViewEncapsulation, Injector } from '@angular/core';
import { MetroComponentBase } from '@shared/metro-component-base';

@Component({
  selector: 'top-bar',
  templateUrl: './top-bar.component.html',
  encapsulation: ViewEncapsulation.None
})
export class TopBarComponent extends MetroComponentBase {

  constructor(
    injector: Injector
  ) {
    super(injector);
  }
}
