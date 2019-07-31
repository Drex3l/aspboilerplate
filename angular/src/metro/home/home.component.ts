import { Component, Injector } from '@angular/core';
import { MetroComponentBase } from '@shared/metro-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  animations: [appModuleAnimation()]
})
export class HomeComponent  extends MetroComponentBase  {

  constructor(
    injector: Injector
) {
    super(injector);
}


}
