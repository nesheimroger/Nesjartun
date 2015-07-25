(function() {
  (function($, window) {
    var equalizeHeights, loadImages;
    equalizeHeights = function() {
      var rows;
      rows = $('.row');
      return rows.each((function(_this) {
        return function(index, rowElement) {
          var height, row, sections;
          row = $(rowElement);
          sections = row.find('.content-section');
          if (sections.length > 1) {
            sections.height('auto');
            if (Modernizr.mq('(max-width: 767px)')) {
              return;
            }
            height = 0;
            sections.each(function(index, sectionElement) {
              var sectionHeight;
              sectionHeight = $(sectionElement).height();
              if (sectionHeight > height) {
                height = sectionHeight;
              }
            });
            sections.height(height);
          }
        };
      })(this));
    };
    loadImages = function(callback) {
      var images;
      images = $('img[data-src]');
      return images.each((function(_this) {
        return function(index, element) {
          var src, tag;
          tag = $(element);
          src = tag.data('src');
          return $.get(src, function() {
            tag.attr('src', src);
            return setTimeout(callback, 75);
          });
        };
      })(this));
    };
    $(window).ready(function() {
      loadImages(equalizeHeights);
    });
    $(window).resize(function() {
      equalizeHeights();
    });
  })(jQuery, window);

}).call(this);

//# sourceMappingURL=nesjartun.js.map
