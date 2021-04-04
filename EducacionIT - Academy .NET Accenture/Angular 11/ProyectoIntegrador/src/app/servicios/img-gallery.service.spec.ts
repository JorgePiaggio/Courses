import { TestBed } from '@angular/core/testing';

import { ImgGalleryService } from './img-gallery.service';

describe('ImgGalleryService', () => {
  let service: ImgGalleryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ImgGalleryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
