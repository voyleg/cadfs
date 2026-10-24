import{C as Ot,V as y,n as Z,T as q,Q as ft,o as ht,j as C,p as zt,P as Ct,l as dt,q as Ut,r as it,s as Dt,t as st,I as Rt,u as mt,v as ct,w as F,x as jt,y as pt,z as Pt,h as Mt,A as G,J as It,f as kt,W as Nt,S as Bt,O as Ht,a as Wt,G as _t,H as Yt,D as yt,M as qt,e as Ft,b as Zt,U as Kt,E as Vt,c as Gt,d as Xt,F as $t,R as Qt,B as Jt,g as ot}from"./FXAAShader.BG--lUKr.js";const gt={type:"change"},ut={type:"start"},At={type:"end"},Q=new zt,wt=new Ct,te=Math.cos(70*dt.DEG2RAD),S=new y,O=2*Math.PI,d={NONE:-1,ROTATE:0,DOLLY:1,PAN:2,TOUCH_ROTATE:3,TOUCH_PAN:4,TOUCH_DOLLY_PAN:5,TOUCH_DOLLY_ROTATE:6},nt=1e-6;class ee extends Ot{constructor(t,e=null){super(t,e),this.state=d.NONE,this.target=new y,this.cursor=new y,this.minDistance=0,this.maxDistance=1/0,this.minZoom=0,this.maxZoom=1/0,this.minTargetRadius=0,this.maxTargetRadius=1/0,this.minPolarAngle=0,this.maxPolarAngle=Math.PI,this.minAzimuthAngle=-1/0,this.maxAzimuthAngle=1/0,this.enableDamping=!1,this.dampingFactor=.05,this.enableZoom=!0,this.zoomSpeed=1,this.enableRotate=!0,this.rotateSpeed=1,this.keyRotateSpeed=1,this.enablePan=!0,this.panSpeed=1,this.screenSpacePanning=!0,this.keyPanSpeed=7,this.zoomToCursor=!1,this.autoRotate=!1,this.autoRotateSpeed=2,this.keys={LEFT:"ArrowLeft",UP:"ArrowUp",RIGHT:"ArrowRight",BOTTOM:"ArrowDown"},this.mouseButtons={LEFT:Z.ROTATE,MIDDLE:Z.DOLLY,RIGHT:Z.PAN},this.touches={ONE:q.ROTATE,TWO:q.DOLLY_PAN},this.target0=this.target.clone(),this.position0=this.object.position.clone(),this.zoom0=this.object.zoom,this._cursorStyle="auto",this._domElementKeyEvents=null,this._lastPosition=new y,this._lastQuaternion=new ft,this._lastTargetPosition=new y,this._quat=new ft().setFromUnitVectors(t.up,new y(0,1,0)),this._quatInverse=this._quat.clone().invert(),this._spherical=new ht,this._sphericalDelta=new ht,this._scale=1,this._panOffset=new y,this._rotateStart=new C,this._rotateEnd=new C,this._rotateDelta=new C,this._panStart=new C,this._panEnd=new C,this._panDelta=new C,this._dollyStart=new C,this._dollyEnd=new C,this._dollyDelta=new C,this._dollyDirection=new y,this._mouse=new C,this._performCursorZoom=!1,this._pointers=[],this._pointerPositions={},this._controlActive=!1,this._onPointerMove=se.bind(this),this._onPointerDown=ie.bind(this),this._onPointerUp=oe.bind(this),this._onContextMenu=de.bind(this),this._onMouseWheel=re.bind(this),this._onKeyDown=le.bind(this),this._onTouchStart=he.bind(this),this._onTouchMove=ce.bind(this),this._onMouseDown=ne.bind(this),this._onMouseMove=ae.bind(this),this._interceptControlDown=pe.bind(this),this._interceptControlUp=ue.bind(this),this.domElement!==null&&this.connect(this.domElement),this.update()}set cursorStyle(t){this._cursorStyle=t,t==="grab"?this.domElement.style.cursor="grab":this.domElement.style.cursor="auto"}get cursorStyle(){return this._cursorStyle}connect(t){super.connect(t),this.domElement.addEventListener("pointerdown",this._onPointerDown),this.domElement.addEventListener("pointercancel",this._onPointerUp),this.domElement.addEventListener("contextmenu",this._onContextMenu),this.domElement.addEventListener("wheel",this._onMouseWheel,{passive:!1}),this.domElement.getRootNode().addEventListener("keydown",this._interceptControlDown,{passive:!0,capture:!0}),this.domElement.style.touchAction="none"}disconnect(){this.state=d.NONE,this.domElement.removeEventListener("pointerdown",this._onPointerDown),this.domElement.ownerDocument.removeEventListener("pointermove",this._onPointerMove),this.domElement.ownerDocument.removeEventListener("pointerup",this._onPointerUp),this.domElement.removeEventListener("pointercancel",this._onPointerUp),this.domElement.removeEventListener("wheel",this._onMouseWheel),this.domElement.removeEventListener("contextmenu",this._onContextMenu),this.stopListenToKeyEvents();const t=this.domElement.getRootNode();t.removeEventListener("keydown",this._interceptControlDown,{capture:!0}),t.removeEventListener("keyup",this._interceptControlUp,{capture:!0}),this._controlActive=!1,this._pointers.length=0,this._pointerPositions={},this.domElement.style.touchAction="",this.domElement.style.cursor="auto"}dispose(){this.disconnect()}getPolarAngle(){return this._spherical.phi}getAzimuthalAngle(){return this._spherical.theta}getDistance(){return this.object.position.distanceTo(this.target)}listenToKeyEvents(t){t.addEventListener("keydown",this._onKeyDown),this._domElementKeyEvents=t}stopListenToKeyEvents(){this._domElementKeyEvents!==null&&(this._domElementKeyEvents.removeEventListener("keydown",this._onKeyDown),this._domElementKeyEvents=null)}saveState(){this.target0.copy(this.target),this.position0.copy(this.object.position),this.zoom0=this.object.zoom}reset(){this.target.copy(this.target0),this.object.position.copy(this.position0),this.object.zoom=this.zoom0,this.object.updateProjectionMatrix(),this.dispatchEvent(gt),this.update(),this.state=d.NONE}pan(t,e){this._pan(t,e),this.update()}dollyIn(t){this._dollyIn(t),this.update()}dollyOut(t){this._dollyOut(t),this.update()}rotateLeft(t){this._rotateLeft(t),this.update()}rotateUp(t){this._rotateUp(t),this.update()}update(t=null){const e=this.object.position;S.copy(e).sub(this.target),S.applyQuaternion(this._quat),this._spherical.setFromVector3(S),this.autoRotate&&this.state===d.NONE&&this._rotateLeft(this._getAutoRotationAngle(t)),this.enableDamping?(this._spherical.theta+=this._sphericalDelta.theta*this.dampingFactor,this._spherical.phi+=this._sphericalDelta.phi*this.dampingFactor):(this._spherical.theta+=this._sphericalDelta.theta,this._spherical.phi+=this._sphericalDelta.phi);let s=this.minAzimuthAngle,o=this.maxAzimuthAngle;isFinite(s)&&isFinite(o)&&(s<-Math.PI?s+=O:s>Math.PI&&(s-=O),o<-Math.PI?o+=O:o>Math.PI&&(o-=O),s<=o?this._spherical.theta=Math.max(s,Math.min(o,this._spherical.theta)):this._spherical.theta=this._spherical.theta>(s+o)/2?Math.max(s,this._spherical.theta):Math.min(o,this._spherical.theta)),this._spherical.phi=Math.max(this.minPolarAngle,Math.min(this.maxPolarAngle,this._spherical.phi)),this._spherical.makeSafe(),this.enableDamping===!0?this.target.addScaledVector(this._panOffset,this.dampingFactor):this.target.add(this._panOffset),this.target.sub(this.cursor),this.target.clampLength(this.minTargetRadius,this.maxTargetRadius),this.target.add(this.cursor);let h=!1;if(this.zoomToCursor&&this._performCursorZoom||this.object.isOrthographicCamera)this._spherical.radius=this._clampDistance(this._spherical.radius);else{const a=this._spherical.radius;this._spherical.radius=this._clampDistance(this._spherical.radius*this._scale),h=a!=this._spherical.radius}if(S.setFromSpherical(this._spherical),S.applyQuaternion(this._quatInverse),e.copy(this.target).add(S),this.object.lookAt(this.target),this.enableDamping===!0?(this._sphericalDelta.theta*=1-this.dampingFactor,this._sphericalDelta.phi*=1-this.dampingFactor,this._panOffset.multiplyScalar(1-this.dampingFactor)):(this._sphericalDelta.set(0,0,0),this._panOffset.set(0,0,0)),this.zoomToCursor&&this._performCursorZoom){let a=null;if(this.object.isPerspectiveCamera){const r=S.length();a=this._clampDistance(r*this._scale);const _=r-a;this.object.position.addScaledVector(this._dollyDirection,_),this.object.updateMatrixWorld(),h=!!_}else if(this.object.isOrthographicCamera){const r=new y(this._mouse.x,this._mouse.y,0);r.unproject(this.object);const _=this.object.zoom;this.object.zoom=Math.max(this.minZoom,Math.min(this.maxZoom,this.object.zoom/this._scale)),this.object.updateProjectionMatrix(),h=_!==this.object.zoom;const w=new y(this._mouse.x,this._mouse.y,0);w.unproject(this.object),this.object.position.sub(w).add(r),this.object.updateMatrixWorld(),a=S.length()}else console.warn("WARNING: OrbitControls.js encountered an unknown camera type - zoom to cursor disabled."),this.zoomToCursor=!1;a!==null&&(this.screenSpacePanning?this.target.set(0,0,-1).transformDirection(this.object.matrix).multiplyScalar(a).add(this.object.position):(Q.origin.copy(this.object.position),Q.direction.set(0,0,-1).transformDirection(this.object.matrix),Math.abs(this.object.up.dot(Q.direction))<te?this.object.lookAt(this.target):(wt.setFromNormalAndCoplanarPoint(this.object.up,this.target),Q.intersectPlane(wt,this.target))))}else if(this.object.isOrthographicCamera){const a=this.object.zoom;this.object.zoom=Math.max(this.minZoom,Math.min(this.maxZoom,this.object.zoom/this._scale)),a!==this.object.zoom&&(this.object.updateProjectionMatrix(),h=!0)}return this._scale=1,this._performCursorZoom=!1,h||this._lastPosition.distanceToSquared(this.object.position)>nt||8*(1-this._lastQuaternion.dot(this.object.quaternion))>nt||this._lastTargetPosition.distanceToSquared(this.target)>nt?(this.dispatchEvent(gt),this._lastPosition.copy(this.object.position),this._lastQuaternion.copy(this.object.quaternion),this._lastTargetPosition.copy(this.target),!0):!1}_getAutoRotationAngle(t){return t!==null?O/60*this.autoRotateSpeed*t:O/60/60*this.autoRotateSpeed}_getZoomScale(t){const e=Math.abs(t*.01);return Math.pow(.95,this.zoomSpeed*e)}_rotateLeft(t){this._sphericalDelta.theta-=t}_rotateUp(t){this._sphericalDelta.phi-=t}_panLeft(t,e){S.setFromMatrixColumn(e,0),S.multiplyScalar(-t),this._panOffset.add(S)}_panUp(t,e){this.screenSpacePanning===!0?S.setFromMatrixColumn(e,1):(S.setFromMatrixColumn(e,0),S.crossVectors(this.object.up,S)),S.multiplyScalar(t),this._panOffset.add(S)}_pan(t,e){const s=this.domElement;if(this.object.isPerspectiveCamera){const o=this.object.position;S.copy(o).sub(this.target);let h=S.length();h*=Math.tan(this.object.fov/2*Math.PI/180),this._panLeft(2*t*h/s.clientHeight,this.object.matrix),this._panUp(2*e*h/s.clientHeight,this.object.matrix)}else this.object.isOrthographicCamera?(this._panLeft(t*(this.object.right-this.object.left)/this.object.zoom/s.clientWidth,this.object.matrix),this._panUp(e*(this.object.top-this.object.bottom)/this.object.zoom/s.clientHeight,this.object.matrix)):(console.warn("WARNING: OrbitControls.js encountered an unknown camera type - pan disabled."),this.enablePan=!1)}_dollyOut(t){this.object.isPerspectiveCamera||this.object.isOrthographicCamera?this._scale/=t:(console.warn("WARNING: OrbitControls.js encountered an unknown camera type - dolly/zoom disabled."),this.enableZoom=!1)}_dollyIn(t){this.object.isPerspectiveCamera||this.object.isOrthographicCamera?this._scale*=t:(console.warn("WARNING: OrbitControls.js encountered an unknown camera type - dolly/zoom disabled."),this.enableZoom=!1)}_updateZoomParameters(t,e){if(!this.zoomToCursor)return;this._performCursorZoom=!0;const s=this.domElement.getBoundingClientRect(),o=t-s.left,h=e-s.top,a=s.width,r=s.height;this._mouse.x=o/a*2-1,this._mouse.y=-(h/r)*2+1,this._dollyDirection.set(this._mouse.x,this._mouse.y,1).unproject(this.object).sub(this.object.position).normalize()}_clampDistance(t){return Math.max(this.minDistance,Math.min(this.maxDistance,t))}_handleMouseDownRotate(t){this._rotateStart.set(t.clientX,t.clientY)}_handleMouseDownDolly(t){this._updateZoomParameters(t.clientX,t.clientX),this._dollyStart.set(t.clientX,t.clientY)}_handleMouseDownPan(t){this._panStart.set(t.clientX,t.clientY)}_handleMouseMoveRotate(t){this._rotateEnd.set(t.clientX,t.clientY),this._rotateDelta.subVectors(this._rotateEnd,this._rotateStart).multiplyScalar(this.rotateSpeed);const e=this.domElement;this._rotateLeft(O*this._rotateDelta.x/e.clientHeight),this._rotateUp(O*this._rotateDelta.y/e.clientHeight),this._rotateStart.copy(this._rotateEnd),this.update()}_handleMouseMoveDolly(t){this._dollyEnd.set(t.clientX,t.clientY),this._dollyDelta.subVectors(this._dollyEnd,this._dollyStart),this._dollyDelta.y>0?this._dollyOut(this._getZoomScale(this._dollyDelta.y)):this._dollyDelta.y<0&&this._dollyIn(this._getZoomScale(this._dollyDelta.y)),this._dollyStart.copy(this._dollyEnd),this.update()}_handleMouseMovePan(t){this._panEnd.set(t.clientX,t.clientY),this._panDelta.subVectors(this._panEnd,this._panStart).multiplyScalar(this.panSpeed),this._pan(this._panDelta.x,this._panDelta.y),this._panStart.copy(this._panEnd),this.update()}_handleMouseWheel(t){this._updateZoomParameters(t.clientX,t.clientY),t.deltaY<0?this._dollyIn(this._getZoomScale(t.deltaY)):t.deltaY>0&&this._dollyOut(this._getZoomScale(t.deltaY)),this.update()}_handleKeyDown(t){let e=!1;switch(t.code){case this.keys.UP:t.ctrlKey||t.metaKey||t.shiftKey?this.enableRotate&&this._rotateUp(O*this.keyRotateSpeed/this.domElement.clientHeight):this.enablePan&&this._pan(0,this.keyPanSpeed),e=!0;break;case this.keys.BOTTOM:t.ctrlKey||t.metaKey||t.shiftKey?this.enableRotate&&this._rotateUp(-O*this.keyRotateSpeed/this.domElement.clientHeight):this.enablePan&&this._pan(0,-this.keyPanSpeed),e=!0;break;case this.keys.LEFT:t.ctrlKey||t.metaKey||t.shiftKey?this.enableRotate&&this._rotateLeft(O*this.keyRotateSpeed/this.domElement.clientHeight):this.enablePan&&this._pan(this.keyPanSpeed,0),e=!0;break;case this.keys.RIGHT:t.ctrlKey||t.metaKey||t.shiftKey?this.enableRotate&&this._rotateLeft(-O*this.keyRotateSpeed/this.domElement.clientHeight):this.enablePan&&this._pan(-this.keyPanSpeed,0),e=!0;break}e&&(t.preventDefault(),this.update())}_handleTouchStartRotate(t){if(this._pointers.length===1)this._rotateStart.set(t.pageX,t.pageY);else{const e=this._getSecondPointerPosition(t),s=.5*(t.pageX+e.x),o=.5*(t.pageY+e.y);this._rotateStart.set(s,o)}}_handleTouchStartPan(t){if(this._pointers.length===1)this._panStart.set(t.pageX,t.pageY);else{const e=this._getSecondPointerPosition(t),s=.5*(t.pageX+e.x),o=.5*(t.pageY+e.y);this._panStart.set(s,o)}}_handleTouchStartDolly(t){const e=this._getSecondPointerPosition(t),s=t.pageX-e.x,o=t.pageY-e.y,h=Math.sqrt(s*s+o*o);this._dollyStart.set(0,h)}_handleTouchStartDollyPan(t){this.enableZoom&&this._handleTouchStartDolly(t),this.enablePan&&this._handleTouchStartPan(t)}_handleTouchStartDollyRotate(t){this.enableZoom&&this._handleTouchStartDolly(t),this.enableRotate&&this._handleTouchStartRotate(t)}_handleTouchMoveRotate(t){if(this._pointers.length==1)this._rotateEnd.set(t.pageX,t.pageY);else{const s=this._getSecondPointerPosition(t),o=.5*(t.pageX+s.x),h=.5*(t.pageY+s.y);this._rotateEnd.set(o,h)}this._rotateDelta.subVectors(this._rotateEnd,this._rotateStart).multiplyScalar(this.rotateSpeed);const e=this.domElement;this._rotateLeft(O*this._rotateDelta.x/e.clientHeight),this._rotateUp(O*this._rotateDelta.y/e.clientHeight),this._rotateStart.copy(this._rotateEnd)}_handleTouchMovePan(t){if(this._pointers.length===1)this._panEnd.set(t.pageX,t.pageY);else{const e=this._getSecondPointerPosition(t),s=.5*(t.pageX+e.x),o=.5*(t.pageY+e.y);this._panEnd.set(s,o)}this._panDelta.subVectors(this._panEnd,this._panStart).multiplyScalar(this.panSpeed),this._pan(this._panDelta.x,this._panDelta.y),this._panStart.copy(this._panEnd)}_handleTouchMoveDolly(t){const e=this._getSecondPointerPosition(t),s=t.pageX-e.x,o=t.pageY-e.y,h=Math.sqrt(s*s+o*o);this._dollyEnd.set(0,h),this._dollyDelta.set(0,Math.pow(this._dollyEnd.y/this._dollyStart.y,this.zoomSpeed)),this._dollyOut(this._dollyDelta.y),this._dollyStart.copy(this._dollyEnd);const a=(t.pageX+e.x)*.5,r=(t.pageY+e.y)*.5;this._updateZoomParameters(a,r)}_handleTouchMoveDollyPan(t){this.enableZoom&&this._handleTouchMoveDolly(t),this.enablePan&&this._handleTouchMovePan(t)}_handleTouchMoveDollyRotate(t){this.enableZoom&&this._handleTouchMoveDolly(t),this.enableRotate&&this._handleTouchMoveRotate(t)}_addPointer(t){this._pointers.push(t.pointerId)}_removePointer(t){delete this._pointerPositions[t.pointerId];for(let e=0;e<this._pointers.length;e++)if(this._pointers[e]==t.pointerId){this._pointers.splice(e,1);return}}_isTrackingPointer(t){for(let e=0;e<this._pointers.length;e++)if(this._pointers[e]==t.pointerId)return!0;return!1}_trackPointer(t){let e=this._pointerPositions[t.pointerId];e===void 0&&(e=new C,this._pointerPositions[t.pointerId]=e),e.set(t.pageX,t.pageY)}_getSecondPointerPosition(t){const e=t.pointerId===this._pointers[0]?this._pointers[1]:this._pointers[0];return this._pointerPositions[e]}_customWheelEvent(t){const e=t.deltaMode,s={clientX:t.clientX,clientY:t.clientY,deltaY:t.deltaY};switch(e){case 1:s.deltaY*=16;break;case 2:s.deltaY*=100;break}return t.ctrlKey&&!this._controlActive&&(s.deltaY*=10),s}}function ie(i){this.enabled!==!1&&(this._pointers.length===0&&(this.domElement.setPointerCapture(i.pointerId),this.domElement.ownerDocument.addEventListener("pointermove",this._onPointerMove),this.domElement.ownerDocument.addEventListener("pointerup",this._onPointerUp)),!this._isTrackingPointer(i)&&(this._addPointer(i),i.pointerType==="touch"?this._onTouchStart(i):this._onMouseDown(i),this._cursorStyle==="grab"&&(this.domElement.style.cursor="grabbing")))}function se(i){this.enabled!==!1&&(i.pointerType==="touch"?this._onTouchMove(i):this._onMouseMove(i))}function oe(i){switch(this._removePointer(i),this._pointers.length){case 0:this.domElement.releasePointerCapture(i.pointerId),this.domElement.ownerDocument.removeEventListener("pointermove",this._onPointerMove),this.domElement.ownerDocument.removeEventListener("pointerup",this._onPointerUp),this.dispatchEvent(At),this.state=d.NONE,this._cursorStyle==="grab"&&(this.domElement.style.cursor="grab");break;case 1:const t=this._pointers[0],e=this._pointerPositions[t];this._onTouchStart({pointerId:t,pageX:e.x,pageY:e.y});break}}function ne(i){let t;switch(i.button){case 0:t=this.mouseButtons.LEFT;break;case 1:t=this.mouseButtons.MIDDLE;break;case 2:t=this.mouseButtons.RIGHT;break;default:t=-1}switch(t){case Z.DOLLY:if(this.enableZoom===!1)return;this._handleMouseDownDolly(i),this.state=d.DOLLY;break;case Z.ROTATE:if(i.ctrlKey||i.metaKey||i.shiftKey){if(this.enablePan===!1)return;this._handleMouseDownPan(i),this.state=d.PAN}else{if(this.enableRotate===!1)return;this._handleMouseDownRotate(i),this.state=d.ROTATE}break;case Z.PAN:if(i.ctrlKey||i.metaKey||i.shiftKey){if(this.enableRotate===!1)return;this._handleMouseDownRotate(i),this.state=d.ROTATE}else{if(this.enablePan===!1)return;this._handleMouseDownPan(i),this.state=d.PAN}break;default:this.state=d.NONE}this.state!==d.NONE&&this.dispatchEvent(ut)}function ae(i){switch(this.state){case d.ROTATE:if(this.enableRotate===!1)return;this._handleMouseMoveRotate(i);break;case d.DOLLY:if(this.enableZoom===!1)return;this._handleMouseMoveDolly(i);break;case d.PAN:if(this.enablePan===!1)return;this._handleMouseMovePan(i);break}}function re(i){this.enabled===!1||this.enableZoom===!1||this.state!==d.NONE||(i.preventDefault(),this.dispatchEvent(ut),this._handleMouseWheel(this._customWheelEvent(i)),this.dispatchEvent(At))}function le(i){this.enabled!==!1&&this._handleKeyDown(i)}function he(i){switch(this._trackPointer(i),this._pointers.length){case 1:switch(this.touches.ONE){case q.ROTATE:if(this.enableRotate===!1)return;this._handleTouchStartRotate(i),this.state=d.TOUCH_ROTATE;break;case q.PAN:if(this.enablePan===!1)return;this._handleTouchStartPan(i),this.state=d.TOUCH_PAN;break;default:this.state=d.NONE}break;case 2:switch(this.touches.TWO){case q.DOLLY_PAN:if(this.enableZoom===!1&&this.enablePan===!1)return;this._handleTouchStartDollyPan(i),this.state=d.TOUCH_DOLLY_PAN;break;case q.DOLLY_ROTATE:if(this.enableZoom===!1&&this.enableRotate===!1)return;this._handleTouchStartDollyRotate(i),this.state=d.TOUCH_DOLLY_ROTATE;break;default:this.state=d.NONE}break;default:this.state=d.NONE}this.state!==d.NONE&&this.dispatchEvent(ut)}function ce(i){switch(this._trackPointer(i),this.state){case d.TOUCH_ROTATE:if(this.enableRotate===!1)return;this._handleTouchMoveRotate(i),this.update();break;case d.TOUCH_PAN:if(this.enablePan===!1)return;this._handleTouchMovePan(i),this.update();break;case d.TOUCH_DOLLY_PAN:if(this.enableZoom===!1&&this.enablePan===!1)return;this._handleTouchMoveDollyPan(i),this.update();break;case d.TOUCH_DOLLY_ROTATE:if(this.enableZoom===!1&&this.enableRotate===!1)return;this._handleTouchMoveDollyRotate(i),this.update();break;default:this.state=d.NONE}}function de(i){this.enabled!==!1&&i.preventDefault()}function pe(i){i.key==="Control"&&(this._controlActive=!0,this.domElement.getRootNode().addEventListener("keyup",this._interceptControlUp,{passive:!0,capture:!0}))}function ue(i){i.key==="Control"&&(this._controlActive=!1,this.domElement.getRootNode().removeEventListener("keyup",this._interceptControlUp,{passive:!0,capture:!0}))}st.line={worldUnits:{value:1},linewidth:{value:1},resolution:{value:new C},dashOffset:{value:0},dashScale:{value:1},dashSize:{value:1},gapSize:{value:1}};it.line={uniforms:Dt.merge([st.common,st.fog,st.line]),vertexShader:`
		#include <common>
		#include <color_pars_vertex>
		#include <fog_pars_vertex>
		#include <logdepthbuf_pars_vertex>
		#include <clipping_planes_pars_vertex>

		uniform float linewidth;
		uniform vec2 resolution;

		attribute vec3 instanceStart;
		attribute vec3 instanceEnd;

		attribute vec3 instanceColorStart;
		attribute vec3 instanceColorEnd;

		#ifdef WORLD_UNITS

			varying vec4 worldPos;
			varying vec3 worldStart;
			varying vec3 worldEnd;

			#ifdef USE_DASH

				varying vec2 vUv;

			#endif

		#else

			varying vec2 vUv;

		#endif

		#ifdef USE_DASH

			uniform float dashScale;
			attribute float instanceDistanceStart;
			attribute float instanceDistanceEnd;
			varying float vLineDistance;

		#endif

		float trimSegmentAlpha( const in vec4 start, const in vec4 end ) {

			// compute the interpolation factor needed to trim the segment so it terminates
			// between the camera plane and the near plane

			// conservative estimate of the near plane
			float a = projectionMatrix[ 2 ][ 2 ]; // 3nd entry in 3th column
			float b = projectionMatrix[ 3 ][ 2 ]; // 3nd entry in 4th column

			// we need different nearEstimate formula for reversed and default depth buffer
			// a is positive with a reversed depth buffer so it can be used for controlling the code flow
			float nearEstimate = ( a > 0.0 ) ? ( - b / ( a + 1.0 ) ) : ( - 0.5 * b / a );

			return ( nearEstimate - start.z ) / ( end.z - start.z );

		}

		void main() {

			#ifdef USE_COLOR

				vColor.xyz = ( position.y < 0.5 ) ? instanceColorStart : instanceColorEnd;

			#endif

			float aspect = resolution.x / resolution.y;

			// camera space
			vec4 start = modelViewMatrix * vec4( instanceStart, 1.0 );
			vec4 end = modelViewMatrix * vec4( instanceEnd, 1.0 );

			#ifdef USE_DASH

				float lineDistanceStart = dashScale * instanceDistanceStart;
				float lineDistanceEnd = dashScale * instanceDistanceEnd;

			#endif

			#ifdef WORLD_UNITS

				worldStart = start.xyz;
				worldEnd = end.xyz;

			#else

				vUv = uv;

			#endif

			// special case for perspective projection, and segments that terminate either in, or behind, the camera plane
			// clearly the gpu firmware has a way of addressing this issue when projecting into ndc space
			// but we need to perform ndc-space calculations in the shader, so we must address this issue directly
			// perhaps there is a more elegant solution -- WestLangley

			bool perspective = ( projectionMatrix[ 2 ][ 3 ] == - 1.0 ); // 4th entry in the 3rd column

			if ( perspective ) {

				if ( start.z < 0.0 && end.z >= 0.0 ) {

					float alpha = trimSegmentAlpha( start, end );
					end.xyz = mix( start.xyz, end.xyz, alpha );

					#ifdef USE_DASH

						lineDistanceEnd = mix( lineDistanceStart, lineDistanceEnd, alpha );

					#endif

				} else if ( end.z < 0.0 && start.z >= 0.0 ) {

					float alpha = trimSegmentAlpha( end, start );
					start.xyz = mix( end.xyz, start.xyz, alpha );

					#ifdef USE_DASH

						lineDistanceStart = mix( lineDistanceEnd, lineDistanceStart, alpha );

					#endif

				}

			}

			#ifdef USE_DASH

				vLineDistance = ( position.y < 0.5 ) ? lineDistanceStart : lineDistanceEnd;
				vUv = uv;

			#endif

			// clip space
			vec4 clipStart = projectionMatrix * start;
			vec4 clipEnd = projectionMatrix * end;

			// ndc space
			vec3 ndcStart = clipStart.xyz / clipStart.w;
			vec3 ndcEnd = clipEnd.xyz / clipEnd.w;

			// direction
			vec2 dir = ndcEnd.xy - ndcStart.xy;

			// account for clip-space aspect ratio
			dir.x *= aspect;
			dir = normalize( dir );

			#ifdef WORLD_UNITS

				vec3 worldDir = normalize( end.xyz - start.xyz );
				vec3 tmpFwd = normalize( mix( start.xyz, end.xyz, 0.5 ) );
				vec3 worldUp = normalize( cross( worldDir, tmpFwd ) );
				vec3 worldFwd = cross( worldDir, worldUp );
				worldPos = position.y < 0.5 ? start: end;

				// height offset
				float hw = linewidth * 0.5;
				worldPos.xyz += position.x < 0.0 ? hw * worldUp : - hw * worldUp;

				// don't extend the line if we're rendering dashes because we
				// won't be rendering the endcaps
				#ifndef USE_DASH

					// cap extension
					worldPos.xyz += position.y < 0.5 ? - hw * worldDir : hw * worldDir;

					// add width to the box
					worldPos.xyz += worldFwd * hw;

					// endcaps
					if ( position.y > 1.0 || position.y < 0.0 ) {

						worldPos.xyz -= worldFwd * 2.0 * hw;

					}

				#endif

				// project the worldpos
				vec4 clip = projectionMatrix * worldPos;

				// shift the depth of the projected points so the line
				// segments overlap neatly
				vec3 clipPose = ( position.y < 0.5 ) ? ndcStart : ndcEnd;
				clip.z = clipPose.z * clip.w;

			#else

				vec2 offset = vec2( dir.y, - dir.x );
				// undo aspect ratio adjustment
				dir.x /= aspect;
				offset.x /= aspect;

				// sign flip
				if ( position.x < 0.0 ) offset *= - 1.0;

				// endcaps
				if ( position.y < 0.0 ) {

					offset += - dir;

				} else if ( position.y > 1.0 ) {

					offset += dir;

				}

				// adjust for linewidth
				offset *= linewidth;

				// adjust for clip-space to screen-space conversion // maybe resolution should be based on viewport ...
				offset /= resolution.y;

				// select end
				vec4 clip = ( position.y < 0.5 ) ? clipStart : clipEnd;

				// back to clip space
				offset *= clip.w;

				clip.xy += offset;

			#endif

			gl_Position = clip;

			vec4 mvPosition = ( position.y < 0.5 ) ? start : end; // this is an approximation

			#include <logdepthbuf_vertex>
			#include <clipping_planes_vertex>
			#include <fog_vertex>

		}
		`,fragmentShader:`
		uniform vec3 diffuse;
		uniform float opacity;
		uniform float linewidth;

		#ifdef USE_DASH

			uniform float dashOffset;
			uniform float dashSize;
			uniform float gapSize;

		#endif

		varying float vLineDistance;

		#ifdef WORLD_UNITS

			varying vec4 worldPos;
			varying vec3 worldStart;
			varying vec3 worldEnd;

			#ifdef USE_DASH

				varying vec2 vUv;

			#endif

		#else

			varying vec2 vUv;

		#endif

		#include <common>
		#include <color_pars_fragment>
		#include <fog_pars_fragment>
		#include <logdepthbuf_pars_fragment>
		#include <clipping_planes_pars_fragment>

		vec2 closestLineToLine(vec3 p1, vec3 p2, vec3 p3, vec3 p4) {

			float mua;
			float mub;

			vec3 p13 = p1 - p3;
			vec3 p43 = p4 - p3;

			vec3 p21 = p2 - p1;

			float d1343 = dot( p13, p43 );
			float d4321 = dot( p43, p21 );
			float d1321 = dot( p13, p21 );
			float d4343 = dot( p43, p43 );
			float d2121 = dot( p21, p21 );

			float denom = d2121 * d4343 - d4321 * d4321;

			float numer = d1343 * d4321 - d1321 * d4343;

			mua = numer / denom;
			mua = clamp( mua, 0.0, 1.0 );
			mub = ( d1343 + d4321 * ( mua ) ) / d4343;
			mub = clamp( mub, 0.0, 1.0 );

			return vec2( mua, mub );

		}

		void main() {

			float alpha = opacity;
			vec4 diffuseColor = vec4( diffuse, alpha );

			#include <clipping_planes_fragment>

			#ifdef USE_DASH

				if ( vUv.y < - 1.0 || vUv.y > 1.0 ) discard; // discard endcaps

				if ( mod( vLineDistance + dashOffset, dashSize + gapSize ) > dashSize ) discard; // todo - FIX

			#endif

			#ifdef WORLD_UNITS

				// Find the closest points on the view ray and the line segment
				vec3 rayEnd = normalize( worldPos.xyz ) * 1e5;
				vec3 lineDir = worldEnd - worldStart;
				vec2 params = closestLineToLine( worldStart, worldEnd, vec3( 0.0, 0.0, 0.0 ), rayEnd );

				vec3 p1 = worldStart + lineDir * params.x;
				vec3 p2 = rayEnd * params.y;
				vec3 delta = p1 - p2;
				float len = length( delta );
				float norm = len / linewidth;

				#ifndef USE_DASH

					#ifdef USE_ALPHA_TO_COVERAGE

						float dnorm = fwidth( norm );
						alpha = 1.0 - smoothstep( 0.5 - dnorm, 0.5 + dnorm, norm );

					#else

						if ( norm > 0.5 ) {

							discard;

						}

					#endif

				#endif

			#else

				#ifdef USE_ALPHA_TO_COVERAGE

					// artifacts appear on some hardware if a derivative is taken within a conditional
					float a = vUv.x;
					float b = ( vUv.y > 0.0 ) ? vUv.y - 1.0 : vUv.y + 1.0;
					float len2 = a * a + b * b;
					float dlen = fwidth( len2 );

					if ( abs( vUv.y ) > 1.0 ) {

						alpha = 1.0 - smoothstep( 1.0 - dlen, 1.0 + dlen, len2 );

					}

				#else

					if ( abs( vUv.y ) > 1.0 ) {

						float a = vUv.x;
						float b = ( vUv.y > 0.0 ) ? vUv.y - 1.0 : vUv.y + 1.0;
						float len2 = a * a + b * b;

						if ( len2 > 1.0 ) discard;

					}

				#endif

			#endif

			#include <logdepthbuf_fragment>
			#include <color_fragment>

			gl_FragColor = vec4( diffuseColor.rgb, alpha );

			#include <tonemapping_fragment>
			#include <colorspace_fragment>
			#include <fog_fragment>
			#include <premultiplied_alpha_fragment>

		}
		`};class Tt extends Ut{constructor(t){super({type:"LineMaterial",uniforms:Dt.clone(it.line.uniforms),vertexShader:it.line.vertexShader,fragmentShader:it.line.fragmentShader,clipping:!0}),this.isLineMaterial=!0,this.setValues(t)}get color(){return this.uniforms.diffuse.value}set color(t){this.uniforms.diffuse.value=t}get worldUnits(){return"WORLD_UNITS"in this.defines}set worldUnits(t){t===!0!==this.worldUnits&&(this.needsUpdate=!0),t===!0?this.defines.WORLD_UNITS="":delete this.defines.WORLD_UNITS}get linewidth(){return this.uniforms.linewidth.value}set linewidth(t){this.uniforms.linewidth&&(this.uniforms.linewidth.value=t)}get dashed(){return"USE_DASH"in this.defines}set dashed(t){t===!0!==this.dashed&&(this.needsUpdate=!0),t===!0?this.defines.USE_DASH="":delete this.defines.USE_DASH}get dashScale(){return this.uniforms.dashScale.value}set dashScale(t){this.uniforms.dashScale.value=t}get dashSize(){return this.uniforms.dashSize.value}set dashSize(t){this.uniforms.dashSize.value=t}get dashOffset(){return this.uniforms.dashOffset.value}set dashOffset(t){this.uniforms.dashOffset.value=t}get gapSize(){return this.uniforms.gapSize.value}set gapSize(t){this.uniforms.gapSize.value=t}get opacity(){return this.uniforms.opacity.value}set opacity(t){this.uniforms&&(this.uniforms.opacity.value=t)}get resolution(){return this.uniforms.resolution.value}set resolution(t){this.uniforms.resolution.value.copy(t)}get alphaToCoverage(){return"USE_ALPHA_TO_COVERAGE"in this.defines}set alphaToCoverage(t){this.defines&&(t===!0!==this.alphaToCoverage&&(this.needsUpdate=!0),t===!0?this.defines.USE_ALPHA_TO_COVERAGE="":delete this.defines.USE_ALPHA_TO_COVERAGE)}}const bt=new pt,J=new y;class Lt extends Rt{constructor(){super(),this.isLineSegmentsGeometry=!0,this.type="LineSegmentsGeometry";const t=[-1,2,0,1,2,0,-1,1,0,1,1,0,-1,0,0,1,0,0,-1,-1,0,1,-1,0],e=[-1,2,1,2,-1,1,1,1,-1,-1,1,-1,-1,-2,1,-2],s=[0,2,1,2,3,1,2,4,3,4,5,3,4,6,5,6,7,5];this.setIndex(s),this.setAttribute("position",new mt(t,3)),this.setAttribute("uv",new mt(e,2))}applyMatrix4(t){const e=this.attributes.instanceStart,s=this.attributes.instanceEnd;return e!==void 0&&(e.applyMatrix4(t),s.applyMatrix4(t),e.needsUpdate=!0),this.boundingBox!==null&&this.computeBoundingBox(),this.boundingSphere!==null&&this.computeBoundingSphere(),this}setPositions(t){let e;t instanceof Float32Array?e=t:Array.isArray(t)&&(e=new Float32Array(t));const s=new ct(e,6,1);return this.setAttribute("instanceStart",new F(s,3,0)),this.setAttribute("instanceEnd",new F(s,3,3)),this.instanceCount=this.attributes.instanceStart.count,this.computeBoundingBox(),this.computeBoundingSphere(),this}setColors(t){let e;t instanceof Float32Array?e=t:Array.isArray(t)&&(e=new Float32Array(t));const s=new ct(e,6,1);return this.setAttribute("instanceColorStart",new F(s,3,0)),this.setAttribute("instanceColorEnd",new F(s,3,3)),this}fromWireframeGeometry(t){return this.setPositions(t.attributes.position.array),this}fromEdgesGeometry(t){return this.setPositions(t.attributes.position.array),this}fromMesh(t){return this.fromWireframeGeometry(new jt(t.geometry)),this}fromLineSegments(t){const e=t.geometry;return this.setPositions(e.attributes.position.array),this}computeBoundingBox(){this.boundingBox===null&&(this.boundingBox=new pt);const t=this.attributes.instanceStart,e=this.attributes.instanceEnd;t!==void 0&&e!==void 0&&(this.boundingBox.setFromBufferAttribute(t),bt.setFromBufferAttribute(e),this.boundingBox.union(bt))}computeBoundingSphere(){this.boundingSphere===null&&(this.boundingSphere=new Pt),this.boundingBox===null&&this.computeBoundingBox();const t=this.attributes.instanceStart,e=this.attributes.instanceEnd;if(t!==void 0&&e!==void 0){const s=this.boundingSphere.center;this.boundingBox.getCenter(s);let o=0;for(let h=0,a=t.count;h<a;h++)J.fromBufferAttribute(t,h),o=Math.max(o,s.distanceToSquared(J)),J.fromBufferAttribute(e,h),o=Math.max(o,s.distanceToSquared(J));this.boundingSphere.radius=Math.sqrt(o),isNaN(this.boundingSphere.radius)&&console.error("THREE.LineSegmentsGeometry.computeBoundingSphere(): Computed radius is NaN. The instanced position data is likely to have NaN values.",this)}}toJSON(){}}const at=new G,St=new y,vt=new y,v=new G,E=new G,j=new G,rt=new y,lt=new kt,x=new It,Et=new y,tt=new pt,et=new Pt,I=new G;let k,W;function xt(i,t,e){return I.set(0,0,-t,1).applyMatrix4(i.projectionMatrix),I.multiplyScalar(1/I.w),I.x=W/e.width,I.y=W/e.height,I.applyMatrix4(i.projectionMatrixInverse),I.multiplyScalar(1/I.w),Math.abs(Math.max(I.x,I.y))}function fe(i,t){const e=i.matrixWorld,s=i.geometry,o=s.attributes.instanceStart,h=s.attributes.instanceEnd,a=Math.min(s.instanceCount,o.count);for(let r=0,_=a;r<_;r++){x.start.fromBufferAttribute(o,r),x.end.fromBufferAttribute(h,r),x.applyMatrix4(e);const w=new y,f=new y;k.distanceSqToSegment(x.start,x.end,f,w),f.distanceTo(w)<W*.5&&t.push({point:f,pointOnLine:w,distance:k.origin.distanceTo(f),object:i,face:null,faceIndex:r,uv:null,uv1:null})}}function me(i,t,e){const s=t.projectionMatrix,h=i.material.resolution,a=i.matrixWorld,r=i.geometry,_=r.attributes.instanceStart,w=r.attributes.instanceEnd,f=Math.min(r.instanceCount,_.count),g=-t.near;k.at(1,j),j.w=1,j.applyMatrix4(t.matrixWorldInverse),j.applyMatrix4(s),j.multiplyScalar(1/j.w),j.x*=h.x/2,j.y*=h.y/2,j.z=0,rt.copy(j),lt.multiplyMatrices(t.matrixWorldInverse,a);for(let D=0,A=f;D<A;D++){if(v.fromBufferAttribute(_,D),E.fromBufferAttribute(w,D),v.w=1,E.w=1,v.applyMatrix4(lt),E.applyMatrix4(lt),v.z>g&&E.z>g)continue;if(v.z>g){const M=v.z-E.z,n=(v.z-g)/M;v.lerp(E,n)}else if(E.z>g){const M=E.z-v.z,n=(E.z-g)/M;E.lerp(v,n)}v.applyMatrix4(s),E.applyMatrix4(s),v.multiplyScalar(1/v.w),E.multiplyScalar(1/E.w),v.x*=h.x/2,v.y*=h.y/2,E.x*=h.x/2,E.y*=h.y/2,x.start.copy(v),x.start.z=0,x.end.copy(E),x.end.z=0;const R=x.closestPointToPointParameter(rt,!0);x.at(R,Et);const m=dt.lerp(v.z,E.z,R),P=m>=-1&&m<=1,U=rt.distanceTo(Et)<W*.5;if(P&&U){x.start.fromBufferAttribute(_,D),x.end.fromBufferAttribute(w,D),x.start.applyMatrix4(a),x.end.applyMatrix4(a);const M=new y,n=new y;k.distanceSqToSegment(x.start,x.end,n,M),e.push({point:n,pointOnLine:M,distance:k.origin.distanceTo(n),object:i,face:null,faceIndex:D,uv:null,uv1:null})}}}class _e extends Mt{constructor(t=new Lt,e=new Tt({color:Math.random()*16777215})){super(t,e),this.isLineSegments2=!0,this.type="LineSegments2"}computeLineDistances(){const t=this.geometry,e=t.attributes.instanceStart,s=t.attributes.instanceEnd,o=new Float32Array(2*e.count);for(let a=0,r=0,_=e.count;a<_;a++,r+=2)St.fromBufferAttribute(e,a),vt.fromBufferAttribute(s,a),o[r]=r===0?0:o[r-1],o[r+1]=o[r]+St.distanceTo(vt);const h=new ct(o,2,1);return t.setAttribute("instanceDistanceStart",new F(h,1,0)),t.setAttribute("instanceDistanceEnd",new F(h,1,1)),this}raycast(t,e){const s=this.material.worldUnits,o=t.camera;if(o===null&&!s&&console.error('LineSegments2: "Raycaster.camera" needs to be set in order to raycast against LineSegments2 while worldUnits is set to false.'),s===!1&&(this.material.resolution.x===0||this.material.resolution.y===0))return;const h=t.params.Line2!==void 0&&t.params.Line2.threshold||0;k=t.ray;const a=this.matrixWorld,r=this.geometry,_=this.material;W=_.linewidth+h,r.boundingSphere===null&&r.computeBoundingSphere(),et.copy(r.boundingSphere).applyMatrix4(a);let w;if(s)w=W*.5;else{const g=Math.max(o.near,et.distanceToPoint(k.origin));w=xt(o,g,_.resolution)}if(et.radius+=w,k.intersectsSphere(et)===!1)return;r.boundingBox===null&&r.computeBoundingBox(),tt.copy(r.boundingBox).applyMatrix4(a);let f;if(s)f=W*.5;else{const g=Math.max(o.near,tt.distanceToPoint(k.origin));f=xt(o,g,_.resolution)}tt.expandByScalar(f),k.intersectsBox(tt)!==!1&&(s?fe(this,e):me(this,o,e))}onBeforeRender(t){const e=this.material.uniforms;e&&e.resolution&&(t.getViewport(at),this.material.uniforms.resolution.value.set(at.z,at.w))}}function ye(i,t){const e=new Nt({antialias:!0,powerPreference:"low-power"});e.setPixelRatio(2),e.setClearColor(16777215,1),e.outputColorSpace=Bt,i.append(e.domElement);const s=new Ht(-1,1,1,-1,.01,30);s.position.set(1.5,1.25,1.8),s.lookAt(0,0,0);const o=s.clone(),h=s.quaternion.clone(),a=new Wt,r=new _t;a.add(r),a.add(new Yt(16317695,8493221,2.2));const _=new yt(16777215,2.6);_.position.set(3,5,5),a.add(_);const w=new yt(14151167,.7);w.position.set(-3,2,-2),a.add(w);const f=new qt({color:9224149,roughness:.44,metalness:.08,side:Ft,polygonOffset:!0,polygonOffsetFactor:1,polygonOffsetUnits:128}),g=new Tt({color:2706267,opacity:1,linewidth:1,worldUnits:!1,alphaToCoverage:!1}),D=new Zt(1,1,{type:Kt,samples:Math.min(4,e.capabilities.maxSamples)}),A=new Vt(e,D),N=new Gt,R=new Xt($t);A.addPass(new Qt(a,s)),A.addPass(N),A.addPass(R);const m=new ee(o,e.domElement);m.enablePan=!1,m.enableDamping=!1,m.minZoom=.65,m.maxZoom=4,e.domElement.addEventListener("wheel",u=>u.stopImmediatePropagation(),{capture:!0});let P;function U(){r.quaternion.copy(o.quaternion).invert().premultiply(h),s.zoom=o.zoom,s.updateProjectionMatrix(),A.render()}let M=!1;function n(){return{position:o.position.toArray(),target:m.target.toArray(),zoom:o.zoom}}function c(){U(),M||t?.(n())}m.addEventListener("change",c);function p(){o.position.copy(s.position),o.zoom=1,o.updateProjectionMatrix(),m.target.set(0,0,0),m.update(),U()}function H(){const u=Math.max(1,i.clientWidth),T=Math.max(1,i.clientHeight),b=u/T,l=(b<1?.9:.7)/Math.min(1,b);s.left=-l*b,s.right=l*b,s.top=l,s.bottom=-l,s.updateProjectionMatrix(),o.left=s.left,o.right=s.right,o.top=s.top,o.bottom=s.bottom,o.updateProjectionMatrix(),e.setSize(u,T,!1),A.setSize(u,T),R.uniforms.resolution.value.set(1/(u*e.getPixelRatio()),1/(T*e.getPixelRatio())),U()}function K(){P&&(r.remove(P),P.children.forEach(u=>u.geometry.dispose()),P=void 0)}const B=new ResizeObserver(H);return B.observe(i),p(),H(),{show(u,T){K();let b=0;const l=new Jt;l.setAttribute("position",new ot(new Int16Array(T,b,u.vertices*3),3,!0)),b+=u.vertices*6,l.setAttribute("normal",new ot(new Int16Array(T,b,u.vertices*3),3,!0)),b+=u.vertices*6,l.setIndex(new ot(new Uint32Array(T,b,u.indices),1)),b+=u.indices*4;const z=Float32Array.from(new Int16Array(T,b,u.edgeVertices*3),$=>Math.max($/32767,-1)),X=new Lt().setPositions(z);P=new _t,P.rotation.x=-Math.PI/2,l.computeBoundingBox();const L=l.boundingBox,Y=L.getSize(new y),V=Math.max(Y.x,Y.y,Y.z);if(V>0){const $=1/V;P.scale.setScalar($),P.position.copy(L.getCenter(new y)).multiplyScalar(-$).applyQuaternion(P.quaternion)}P.add(new Mt(l,f),new _e(X,g)),r.add(P),p()},reset:p,viewState:n,setView(u){M=!0;try{o.position.fromArray(u.position),m.target.fromArray(u.target),o.zoom=u.zoom,o.updateProjectionMatrix(),m.update(),U()}finally{M=!1}},zoom(u){o.zoom=dt.clamp(o.zoom*u,m.minZoom,m.maxZoom),o.updateProjectionMatrix(),c()},rotate(u,T){const b=new ht().setFromVector3(o.position.clone().sub(m.target));b.theta+=u,b.phi+=T,b.makeSafe(),o.position.copy(new y().setFromSpherical(b).add(m.target)),m.update(),U()},dispose(){B.disconnect(),m.dispose(),K(),f.dispose(),g.dispose(),N.dispose(),R.dispose(),A.dispose(),e.dispose(),e.domElement.remove()}}}function we(i,t){const e=i.dataset.base,s=[...i.querySelectorAll("[data-operation]")],o=s.find(n=>n.getAttribute("aria-pressed")==="true")?.dataset.operation;let h=t.groups.find(n=>n.id===o)??t.groups[0],a=h.exampleIds.map(n=>t.examples.find(c=>c.id===n));i.dataset.operation=h.id;const r=i.querySelector("[data-example-select]"),_=i.querySelector("[data-status]"),w=[...i.querySelectorAll("[data-view]")],f=[...i.querySelectorAll("[data-method]")].map(n=>({card:n,method:n.dataset.method,viewport:n.querySelector("[data-viewport]"),host:n.querySelector("[data-canvas]"),poster:n.querySelector("[data-poster]"),message:n.querySelector("[data-model-status]"),viewer:void 0}));let g=0,D=0,A=!1,N,R=!1;const m=new Map;function P(n,c){R||f.forEach(p=>{p!==c&&p.viewer?.setView(n)})}function U(){const n=f.find(p=>p.viewport.dataset.state==="ready")?.viewer;if(!n)return;n.reset();const c={...n.viewState(),zoom:a[g].initialZoom??1};f.forEach(p=>p.viewer?.setView(c))}for(const n of f){try{n.viewer=ye(n.host,c=>P(c,n))}catch{n.host.replaceChildren()}n.viewport.addEventListener("keydown",c=>{if(n.viewport.dataset.state!=="ready"||!n.viewer)return;const p={ArrowLeft:()=>n.viewer.rotate(-.15,0),ArrowRight:()=>n.viewer.rotate(.15,0),ArrowUp:()=>n.viewer.rotate(0,-.15),ArrowDown:()=>n.viewer.rotate(0,.15),"+":()=>n.viewer.zoom(1.15),"=":()=>n.viewer.zoom(1.15),"-":()=>n.viewer.zoom(1/1.15),Home:U};p[c.key]&&(c.preventDefault(),p[c.key]())})}async function M(n){g=(n+a.length)%a.length;const c=a[g];i.querySelector(".example-controls").hidden=a.length<2,i.querySelectorAll("[data-next], [data-previous]").forEach(l=>l.disabled=a.length<2),r&&(r.value=String(g));const p=i.querySelector("[data-example-position]");p&&(p.textContent=`${g+1} / ${a.length}`,p.hidden=a.length<2),i.dataset.exampleId=c.id;const H=i.querySelector("[data-input]");H&&(i.querySelector(".comparison-input").hidden=!c.input,c.input?H.src=e+c.input:H.removeAttribute("src"),H.alt=`Input views for model ${c.id}`);const K=i.querySelector("[data-prompt]");K&&(K.textContent=c.prompt||"");const B=++D;N?.abort(),N=new AbortController;const u=N.signal;if(R=!0,i.dataset.loading="true",w.forEach(l=>l.disabled=!0),_.textContent="Loading comparison…",f.forEach(l=>{l.viewport.dataset.state="loading",l.viewport.setAttribute("aria-busy","true")}),await Promise.all(f.map(async l=>{const z=t.models.find(L=>L.id===c.models[l.method]),X=l.card.querySelector("[data-download]");if(l.card.querySelector("[data-unavailable]").hidden=!!z,l.poster.hidden=!z,X.hidden=!z,l.message.textContent="",!z){l.poster.removeAttribute("src"),X.removeAttribute("href"),l.viewport.dataset.state="unavailable",l.viewport.setAttribute("aria-busy","false");return}l.poster.src=e+z.poster,l.poster.style.transform=`scale(${c.initialZoom??1})`,l.poster.alt=`${l.card.querySelector("h3").textContent}, model ${c.id}`,l.card.querySelector("[data-download]").href=e+z.step,l.message.textContent="";try{if(!l.viewer)throw new Error("WebGL unavailable");let L=m.get(z.id);if(!L){const Y=await fetch(e+z.geometry,{signal:u});if(!Y.ok)throw new Error("Download failed");L=await Y.arrayBuffer();const V=new Uint8Array(L,0,Math.min(2,L.byteLength));if(V[0]===31&&V[1]===139&&(L=await new Response(new Blob([L]).stream().pipeThrough(new DecompressionStream("gzip"))).arrayBuffer()),L.byteLength!==z.byteLength)throw new Error("Incomplete geometry");if(B!==D||A)return;m.set(z.id,L),m.size>8&&m.delete(m.keys().next().value)}if(B!==D||A)return;l.viewer.show(z,L),l.viewport.dataset.state="ready"}catch{if(B!==D||A)return;l.viewport.dataset.state="poster",l.message.textContent=l.viewer?"Still render · select again to retry":"Still render"}finally{B===D&&l.viewport.setAttribute("aria-busy","false")}})),B!==D||A)return;R=!1,i.dataset.loading="false",U();const T=f.filter(l=>l.viewport.dataset.state==="ready");w.forEach(l=>l.disabled=T.length===0);const b=f.filter(l=>l.viewport.dataset.state==="unavailable").length;_.textContent=T.length===f.length-b?"":"Still renders shown where 3D is unavailable."}s.forEach(n=>{n.disabled=!1,n.addEventListener("click",()=>{h=t.groups.find(c=>c.id===n.dataset.operation),a=h.exampleIds.map(c=>t.examples.find(p=>p.id===c)),i.dataset.operation=h.id,s.forEach(c=>c.setAttribute("aria-pressed",String(c===n))),i.querySelector("[data-operation-description]").textContent=h.description,r?.replaceChildren(...a.map((c,p)=>new Option(`${p+1} / ${a.length} · ${c.id}`,String(p)))),M(0)})}),r&&(r.disabled=!1),r?.addEventListener("change",()=>{M(Number(r.value))});for(const[n,c]of[["[data-previous]",-1],["[data-next]",1]]){const p=i.querySelector(n);p.disabled=!1,p.addEventListener("click",()=>{M(g+c)})}w.forEach(n=>n.addEventListener("click",()=>{const c=f.find(p=>p.viewport.dataset.state==="ready")?.viewer;c&&(n.dataset.view==="reset"?U():c.zoom(n.dataset.view==="in"?1.15:1/1.15))})),M(0),window.addEventListener("pagehide",()=>{A=!0,N?.abort(),f.forEach(n=>n.viewer?.dispose())},{once:!0})}export{we as i};
