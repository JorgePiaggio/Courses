import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './componentes/about/about.component';
import { AdminComponent } from './componentes/admin/admin.component';
import { HomeComponent } from './componentes/home/home.component';
import { ImageDetailsComponent } from './componentes/image-details/image-details.component';
import { ImageGalleryComponent } from './componentes/image-gallery/image-gallery.component';
import { ViewRegistrarionComponent } from './componentes/view-registrarion/view-registrarion.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NavbarComponent } from './componentes/navbar/navbar.component';
import { FooterComponent } from './componentes/footer/footer.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { LoadWarrantyComponent } from './componentes/load-warranty/load-warranty.component';
import { FilterPipe } from './FilterPipe.pipe';

@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    AdminComponent,
    HomeComponent,
    ImageDetailsComponent,
    ImageGalleryComponent,
    ViewRegistrarionComponent,
    NavbarComponent,
    FooterComponent,
    LoadWarrantyComponent,
    FilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    FontAwesomeModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
