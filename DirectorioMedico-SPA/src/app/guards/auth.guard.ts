import { Injectable } from "@angular/core";
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  UrlTree,
  Router,
} from "@angular/router";
import { Observable } from "rxjs";
import { AuthService } from "../services/auth.service";
import { ToastrAlertService } from "../services/toastr-alert.service";

@Injectable({
  providedIn: "root",
})
export class AuthGuard implements CanActivate {
  constructor(
    private auth: AuthService,
    private router: Router,
    private toastr: ToastrAlertService
  ) {}
  canActivate(): boolean {
    if (this.auth.loggedIn()) {
      return true;
    }

    this.toastr.error("Debe iniciar sesión para acceder a este sitio");
    this.router.navigate(["/index"]);
  }
}
