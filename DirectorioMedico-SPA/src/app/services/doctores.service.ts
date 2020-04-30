import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { Observable } from "rxjs";
import { Doctor } from "../../models/Doctor";

@Injectable({
  providedIn: "root",
})
export class DoctoresService {
  constructor(private http: HttpClient) {}
  baseURL = environment.apiURL;

  obtenerDoctores(): Observable<Doctor[]> {
    return this.http.get<Doctor[]>(this.baseURL + "doctores");
  }

  obtenerDoctoresID(id: any): Observable<Doctor> {
    return this.http.get<Doctor>(this.baseURL + "doctores/" + id);
  }

  agregarDoctor(doctor: any) {
    this.http.post(this.baseURL + "doctores", doctor);
  }

  editarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }

  eliminarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }
}
