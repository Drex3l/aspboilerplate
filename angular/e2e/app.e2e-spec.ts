import { bloggerTemplatePage } from './app.po';

describe('blogger App', function() {
  let page: bloggerTemplatePage;

  beforeEach(() => {
    page = new bloggerTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
