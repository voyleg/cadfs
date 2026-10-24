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
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 40.91804352335485 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            cPlane(context, id + "F1", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E1.cCircle", {"center": v(0, 0) * mm, "radius": 31.370826065540314 * mm, "construction": true});
            skLineSegment(sketch, "E1.0", {"start": v(-22.792239275274127, 31.370826065540314) * mm, "end": v(22.792239275274127, 31.370826065540314) * mm});
            skLineSegment(sketch, "E1.1", {"start": v(22.792239275274127, 31.370826065540314) * mm, "end": v(36.878617827113814, -11.982589301875263) * mm});
            skLineSegment(sketch, "E1.2", {"start": v(36.878617827113814, -11.982589301875263) * mm, "end": v(0, -38.776473527330104) * mm});
            skLineSegment(sketch, "E1.3", {"start": v(0, -38.776473527330104) * mm, "end": v(-36.87861782711381, -11.98258930187527) * mm});
            skLineSegment(sketch, "E1.4", {"start": v(-36.87861782711381, -11.98258930187527) * mm, "end": v(-22.792239275274127, 31.370826065540314) * mm});
            skPoint(sketch, "E1.0.midPoint", {"position": v(0, 31.370826065540314) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F1.planeOp",FACE);
            cPlane(context, id + "F3", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F3.planeOp",FACE);
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E2", {"center": v(0, 0) * mm, "radius": 44.72949786704379 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F3.planeOp",FACE);
            cPlane(context, id + "F5", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F5.planeOp",FACE);
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E3", {"center": v(0, 0) * mm, "radius": 14.70065024791304 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F5.planeOp",FACE);
            cPlane(context, id + "F7", {"entities" : qUnion([Q0]), "cplaneType" : CPlaneType.OFFSET, "offset" : 25.4 * mm, "width" : 152.4 * mm, "height" : 152.4 * mm});
        }
        {
            var Q0;
            Q0=qCreatedBy(id+"F7.planeOp",FACE);
            var sketch = newSketch(context, id + "F8", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 21.309290602984742 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1.0")}),-1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E2")}),1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F6.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F6.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F6.wireOp",EDGE,"E3")}),1.0]])]});
            var Q4;
            Q4=makeQuery(id+"F8.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F8.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F8.wireOp",EDGE,"E4")}),1.0]])]});
            loft(context, id + "F9", {"sheetProfilesArray" : [{ "sheetProfileEntities" : qUnion([Q0]) }, { "sheetProfileEntities" : qUnion([Q1]) }, { "sheetProfileEntities" : qUnion([Q2]) }, { "sheetProfileEntities" : qUnion([Q3]) }, { "sheetProfileEntities" : qUnion([Q4]) }]});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F9.opLoft","CAP_FACE",FACE,{"disambiguationData":[OSD([makeQuery(id+"F8.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F8.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F8.wireOp",EDGE,"E4")}),1.0]])]})])],"isStart":true});
            shell(context, id + "F10", {"entities" : qUnion([Q0]), "thickness" : 2.54 * mm});
        }
    });