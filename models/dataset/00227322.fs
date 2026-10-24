FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 50.8 * mm});
            skLineSegment(sketch, "E1", {"start": v(-54.15041744709015, 5.30453072860837) * mm, "end": v(55.255524814128876, 5.30453072860837) * mm});
            skLineSegment(sketch, "E2", {"start": v(-53.929395973682404, -4.199420101940632) * mm, "end": v(56.3606359064579, -4.199420101940632) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 75.14751702547073) * mm, "end": v(0, -63.2123202085495) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E3");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"disambiguationData":[OD(0.0)],"derivedFrom":[subQ1,subQ0]});Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,-1.0]])],"derivedFrom":subQ1}),1.0]])]});}
            var Q1;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E3");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"disambiguationData":[OD(1.0)],"derivedFrom":[subQ1,subQ0]});Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,-1.0]])],"derivedFrom":subQ1}),1.0]])]});}
            var Q2;
            Q2=sQuery(id+"F0.wireOp",EDGE,"E3");
            revolve(context, id + "F1", {"entities" : qUnion([Q0, Q1]), "axis" : qUnion([Q2]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E4.bottom", {"start": v(-47.74077236652374, 4.6414644457399845) * mm, "end": v(48.18281903862953, 4.6414644457399845) * mm});
            skLineSegment(sketch, "E4.top", {"start": v(-47.74077236652374, -3.3153314143419266) * mm, "end": v(48.18281903862953, -3.3153314143419266) * mm});
            skLineSegment(sketch, "E4.left", {"start": v(-47.74077236652374, 4.6414644457399845) * mm, "end": v(-47.74077236652374, -3.3153314143419266) * mm});
            skLineSegment(sketch, "E4.right", {"start": v(48.18281903862953, 4.6414644457399845) * mm, "end": v(48.18281903862953, -3.3153314143419266) * mm});
            skLineSegment(sketch, "E5", {"start": v(0, 4.6414644457399845) * mm, "end": v(0, -3.3153314143419266) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F2.wireOp",EDGE,"E4.left");Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),1.0]])]});}
            var Q1;
            Q1=sQuery(id+"F2.wireOp",EDGE,"E5");
            revolve(context, id + "F3", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E6", {"center": v(0, 0) * mm, "radius": 9.348477873897501 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "depth" : 55.88 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E6")])],"isStart":false});
            shell(context, id + "F6", {"entities" : qUnion([Q0]), "thickness" : 2.54 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F7", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E7", {"center": v(0, 0) * mm, "radius": 6.4096408896148205 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F7",true);
            extrude(context, id + "F8", {"entities" : qUnion([Q0]), "depth" : 58.42 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E6")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F8.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F7.wireOp",EDGE,"E7")])],"isStart":false});
            fillet(context, id + "F9", {"entities" : qUnion([Q0, Q1]), "radius" : 5.08 * mm, "tangentPropagation" : true, "allowEdgeOverflow" : false});
        }
    });