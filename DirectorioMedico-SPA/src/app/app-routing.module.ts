import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { WebviewComponent } from "./components/webview/webview.component";
import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { ListadoDoctoresComponent } from "./components/listado-doctores/listado-doctores.component";
import { PerfilDoctorComponent } from "./components/perfil-doctor/perfil-doctor.component";

const routes: Routes = [
  {
    path: "home",
    component: WebviewComponent,
  },
  {
    path: "dashboard",
    component: DashboardComponent,
  },
  {
    path: "doctores",
    component: ListadoDoctoresComponent,
  },
  {
    path: "doctor",
    component: PerfilDoctorComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
