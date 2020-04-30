import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from "./app.component";
import { NavbarComponent } from "./components/shared/navbar/navbar.component";
import { FooterComponent } from "./components/shared/footer/footer.component";
import { SidebarComponent } from "./components/shared/sidebar/sidebar.component";
import { ListadoDoctoresComponent } from "./components/listado-doctores/listado-doctores.component";
import { PerfilDoctorComponent } from "./components/perfil-doctor/perfil-doctor.component";
import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { WebviewComponent } from "./components/webview/webview.component";
import { AgendaComponent } from "./components/agenda/agenda.component";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    SidebarComponent,
    ListadoDoctoresComponent,
    PerfilDoctorComponent,
    DashboardComponent,
    WebviewComponent,
    AgendaComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
