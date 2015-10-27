function initSlider(slid) {
    interact('#'+slid)                   // target the matches of that selector
      .origin('self')                     // (0, 0) will be the element's top-left
      .restrict({ drag: 'self' })           // keep the drag within the element
      .inertia(true)                      // start inertial movement if thrown
      .draggable({                        // make the element fire drag events
          max: Infinity                     // allow drags on multiple elements
      })
      .on('dragmove', function (event) {  // call this function on every move
          var sliderWidth = interact.getElementRect(event.target.parentNode).width,
              value = event.pageX / sliderWidth;

          event.target.style.paddingLeft = (value * 100) + '%';
          event.target.setAttribute('data-value', value.toFixed(2));

          console.log(slid + '  -  ', value.toFixed(2))
      });
}
initSlider('sl1');
initSlider('sl2');
initSlider('sl3');
interact.maxInteractions(Infinity);   // Allow multiple interactions


////from interact.js site
///* The dragging code for '.draggable' from the demo above
// * applies to this demo as well so it doesn't have to be repeated. */

//// enable draggables to be dropped into this
//interact('.dropzone').dropzone({
//    // only accept elements matching this CSS selector
//    accept: '#yes-drop',
//    // Require a 75% element overlap for a drop to be possible
//    overlap: 0.75,

//    // listen for drop related events:

//    ondropactivate: function (event) {
//        // add active dropzone feedback
//        event.target.classList.add('drop-active');
//    },
//    ondragenter: function (event) {
//        var draggableElement = event.relatedTarget,
//            dropzoneElement = event.target;

//        // feedback the possibility of a drop
//        dropzoneElement.classList.add('drop-target');
//        draggableElement.classList.add('can-drop');
//        draggableElement.textContent = 'Dragged in';
//    },
//    ondragleave: function (event) {
//        // remove the drop feedback style
//        event.target.classList.remove('drop-target');
//        event.relatedTarget.classList.remove('can-drop');
//        event.relatedTarget.textContent = 'Dragged out';
//    },
//    ondrop: function (event) {
//        event.relatedTarget.textContent = 'Dropped';
//    },
//    ondropdeactivate: function (event) {
//        // remove active dropzone feedback
//        event.target.classList.remove('drop-active');
//        event.target.classList.remove('drop-target');
//    }
//});