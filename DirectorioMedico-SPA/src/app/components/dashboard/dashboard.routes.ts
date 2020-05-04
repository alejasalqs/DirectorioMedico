import { Routes } from "@angular/router";
import { DashboardComponent } from "./dashboard.component";
import { MiPerfilComponent } from "../dash/mi-perfil/mi-perfil.component";

export const DASHBOARD_ROUTES: Routes = [
  {
    path: "home",
    component: DashboardComponent,
  },
  {
    path: "miperfil",
    component: MiPerfilComponent,
  },
  {
    path: "**",
    redirectTo: "home",
    pathMatch: "full",
  },
];
