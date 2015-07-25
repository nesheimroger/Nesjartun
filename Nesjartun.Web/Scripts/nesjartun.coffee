# CoffeeScript
(($, window) ->

    equalizeHeights = () ->    
        

        rows = $('.row');
        rows.each (index, rowElement) =>
    
            row = $(rowElement);
            sections = row.find('.content-section');
            if sections.length > 1
                sections.height('auto')

                if Modernizr.mq('(max-width: 767px)')
                    return;
            
                height = 0;
                sections.each (index, sectionElement) =>
                    sectionHeight = $(sectionElement).outerHeight()
                    
                    
                    if sectionHeight > height
                        height = sectionHeight;
                    return;
                sections.height(height)
                return;
                
    $(window).ready -> equalizeHeights(); return;
    $(window).resize -> equalizeHeights(); return;
    
    return;
) jQuery, window