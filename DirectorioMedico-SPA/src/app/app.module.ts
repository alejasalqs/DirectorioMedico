import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { ToastrModule } from "ngx-toastr";

import { AppComponent } from "./app.component";
import { NavbarComponent } from "./components/shared/navbar/navbar.component";
import { FooterComponent } from "./components/shared/footer/footer.component";
import { SidebarComponent } from "./components/shared/sidebar/sidebar.component";
import { ListadoDoctoresComponent } from "./components/listado-doctores/listado-doctores.component";
import { PerfilDoctorComponent } from "./components/perfil-doctor/perfil-doctor.component";
import { DashboardComponent } from "./components/dashboard/dashboard.component";
import { WebviewComponent } from "./components/webview/webview.component";
import { AgendaComponent } from "./components/agenda/agenda.component";
import { LoginComponent } from "./components/shared/login/login.component";
import { DashboardfooterComponent } from "./components/shared/dashboardfooter/dashboardfooter.component";
import { JwtModule } from "@auth0/angular-jwt";
import { MiPerfilComponent } from "./components/dash/mi-perfil/mi-perfil.component";
import { HomeComponent } from "./components/dash/home/home.component";
import { ErrorInterceptorProvider } from "./services/error.interceptor";
import { DoctoresDetalleResolver } from "./Resolvers/doctor-detalle.resolver";
import { DoctorListaResolver } from "./Resolvers/doctor-lista.resolver";

export function tokenGetter() {
  return localStorage.getItem("token");
}

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
    LoginComponent,
    DashboardfooterComponent,
    MiPerfilComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: ["localhost:5000"],
        blacklistedRoutes: ["localhost:5000/auth"],
      },
    }),
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
  ],
  providers: [
    ErrorInterceptorProvider,
    DoctoresDetalleResolver,
    DoctorListaResolver,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
