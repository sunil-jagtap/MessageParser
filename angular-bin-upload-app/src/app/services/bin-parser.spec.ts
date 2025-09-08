import { TestBed } from '@angular/core/testing';

import { BinParser } from './bin-parser';

describe('BinParser', () => {
  let service: BinParser;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BinParser);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
