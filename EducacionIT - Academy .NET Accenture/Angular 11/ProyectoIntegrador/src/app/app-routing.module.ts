import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './componentes/about/about.component';
import { AdminComponent } from './componentes/admin/admin.component';
import { FooterComponent } from './componentes/footer/footer.component';
import { HomeComponent } from './componentes/home/home.component';
import { ImageDetailsComponent } from './componentes/image-details/image-details.component';
import { ImageGalleryComponent } from './componentes/image-gallery/image-gallery.component';
import { LoadWarrantyComponent } from './componentes/load-warranty/load-warranty.component';
import { NavbarComponent } from './componentes/navbar/navbar.component';
import { ViewRegistrarionComponent } from './componentes/view-registrarion/view-registrarion.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'admin',
    component: AdminComponent
  },
  {
    path: 'about',
    component: AboutComponent
  },
  {
    path: 'image-details/:id',
    component: ImageDetailsComponent
  },
  {
    path: 'image-gallery',
    component: ImageGalleryComponent
  },
  {
    path: 'view/:id',
    component: ViewRegistrarionComponent
  },
  {
    path: 'navbar',
    component: NavbarComponent
  },
  {
    path: 'footer',
    component: FooterComponent
  },
  {
    path:'load-warranty',
    component: LoadWarrantyComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
