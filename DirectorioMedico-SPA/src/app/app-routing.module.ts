import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { WebviewComponent } from "./components/webview/webview.component";
import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { ListadoDoctoresComponent } from "./components/listado-doctores/listado-doctores.component";
import { PerfilDoctorComponent } from "./components/perfil-doctor/perfil-doctor.component";
import { LoginComponent } from "./components/shared/login/login.component";
import { AuthGuard } from "./guards/auth.guard";
import { DASHBOARD_ROUTES } from "./components/dashboard/dashboard.routes";

const routes: Routes = [
  {
    path: "index",
    component: WebviewComponent,
  },
  {
    path: "dashboard",
    component: DashboardComponent,
    runGuardsAndResolvers: "always",
    canActivate: [AuthGuard],
    children: DASHBOARD_ROUTES,
  },
  {
    path: "doctores",
    component: ListadoDoctoresComponent,
  },
  {
    path: "doctor/:id",
    component: PerfilDoctorComponent,
  },
  {
    path: "login",
    component: LoginComponent,
  },
  {
    path: "**",
    redirectTo: "index",
    pathMatch: "full",
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
