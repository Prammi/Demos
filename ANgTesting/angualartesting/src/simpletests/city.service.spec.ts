import { CityService } from './city.service';
import { TestBed, inject } from "@angular/core/testing";
import {    HttpClientTestingModule,    HttpTestingController} from "@angular/common/http/testing";
import { City } from 'src/models/City';


fdescribe('CityService', () => {

    let _cityService: CityService;
    let _httpTestingController: HttpTestingController;

    let _city: City[];
    let apiUrl = 'http://localhost:3000/City';


    beforeEach(() => {
        TestBed.configureTestingModule({
            imports: [HttpClientTestingModule],
            providers: [CityService]
        });
    });

    beforeEach(() => {        
        _cityService = TestBed.get(CityService);
        _httpTestingController=TestBed.get(HttpTestingController);
    });

    afterEach(()=>{
        _httpTestingController.verify();
    })

    it("should return all cities", () => {
        _city =[{name: "SUN"}];
        _cityService.getCities().subscribe((city)=>{
            expect(_city).toBe(city);
        })  
        const req   =_httpTestingController.expectOne(apiUrl); 
        expect(req.cancelled).toBeFalsy();
        expect(req.request.responseType).toEqual('json');
        req.flush(_city);
    });

    it("should insert  new city", () => {
        let city ={name: "SUN"};
        _cityService.addCity(city).subscribe(()=>{
            expect(_city).toBeTruthy();
        })  
        const req   =_httpTestingController.expectOne(apiUrl); 
        expect(req.cancelled).toBeFalsy();
        expect(req.request.responseType).toEqual('json');
        req.flush(_city);
    });
});