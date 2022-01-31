import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { AdminComponent } from './admin/admin.component';
import { DetailsComponent } from './details/details.component';

const routes: Routes = [
    {
        path: 'dashboard',
        component: LayoutComponent,
        children: [
            { path: '', redirectTo: 'admin', pathMatch: 'full' },
            { path: 'admin', component: AdminComponent },
            { path: 'details', component: DetailsComponent },
            { path: 'details/:param', component: DetailsComponent },
            { path: 'details/:param/:someOtherParam', component: DetailsComponent },
        ]
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DashboardRoutingModule { }
