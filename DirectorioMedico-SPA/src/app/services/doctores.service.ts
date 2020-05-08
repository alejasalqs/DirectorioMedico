import { Injectable } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { environment } from "../../environments/environment";
import { Observable } from "rxjs";
import { Doctor } from "../../models/Doctor";
import { PaginatedResult } from "../../models/pagination";
import { map } from "rxjs/operators";

/*

Creado por: asalguero
Fecha: 20/04/2020

*/

@Injectable({
  providedIn: "root",
})
export class DoctoresService {
  constructor(private http: HttpClient) {}
  baseURL = environment.apiURL;

  /**
   * Obtiene una lista con todos los doctores del endpoint.
   * @returns Observable
   */
  obtenerDoctores(
    page?,
    itemsPorPagina?
  ): Observable<PaginatedResult<Doctor[]>> {
    const paginatedResult: PaginatedResult<Doctor[]> = new PaginatedResult<
      Doctor[]
    >();

    let params = new HttpParams();

    if (page != null && itemsPorPagina != null) {
      params = params.append("numeroPagina", page);
      params = params.append("tamanoPagina", itemsPorPagina);
    }

    return this.http
      .get<Doctor[]>(this.baseURL + "doctores", { observe: "response", params })
      .pipe(
        map((response) => {
          paginatedResult.result = response.body;
          if (response.headers.get("Pagination") != null) {
            paginatedResult.pagination = JSON.parse(
              response.headers.get("Pagination")
            );
          }
          return paginatedResult;
        })
      );
  }

  /**
   * Obtiene la información detallada de un Doctor mediante un ID.
   * @param id Identificador del Doctor que se desea consultar
   * @returns Observable
   */
  obtenerDoctoresID(id: any): Observable<Doctor> {
    return this.http.get<Doctor>(this.baseURL + "doctores/" + id);
  }

  agregarDoctor(doctor: any) {
    this.http.post(this.baseURL + "doctores", doctor);
  }

  /**
   * Edita la información de un doctor especificado por un id.
   * @param id Identificador del Doctor que se desea editar
   * @returns Observable
   */
  editarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }

  eliminarDoctor(doctor: any, id: any) {
    this.http.post(this.baseURL + "doctores/" + id, doctor);
  }
}
