import { Injector } from '@angular/core';
import { PermissionCheckerService } from 'abp-ng2-module/dist/src/auth/permission-checker.service';
import { AppConsts } from './AppConsts';
import { LocalizationService } from 'abp-ng2-module/dist/src/localization/localization.service';

export abstract class MetroComponentBase {

    localizationSourceName = AppConsts.localization.defaultLocalizationSourceName;
    
    localization: LocalizationService;
    permission: PermissionCheckerService;

    constructor(injector: Injector) {
        this.localization = injector.get(LocalizationService);
        this.permission = injector.get(PermissionCheckerService);
    }
    l(key: string, ...args: any[]): string {
        let localizedText = this.localization.localize(key, this.localizationSourceName);

        if (!localizedText) {
            localizedText = key;
        }

        if (!args || !args.length) {
            return localizedText;
        }

        args.unshift(localizedText);
        return abp.utils.formatString.apply(this, args);
    }
    isGranted(permissionName: string): boolean {
        return this.permission.isGranted(permissionName);
    }
}
