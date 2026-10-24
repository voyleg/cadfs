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
            skArc(sketch, "E0", {"start": v(96.59258262890684, -25.88190451025207) * mm, "mid": v(100, 0) * mm, "end": v(96.59258262890683, 25.881904510252102) * mm});
            skLineSegment(sketch, "E1", {"start": v(0, 0) * mm, "end": v(96.59258262890683, 25.881904510252102) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, 0) * mm, "end": v(96.5925826289069, -25.881904510252106) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 10 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2")])],"isStart":true});
            transform(context, id + "F2", {"entities" : qUnion([Q0]), "transformType" : TransformType.ROTATION, "transformAxis" : qUnion([Q1]), "angle" : 30 * degree, "makeCopy" : false});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E3", {"start": v(0, 59.27937850356102) * mm, "end": v(0, -59.27937850356102) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_BODY",BODY,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2")])]});
            var Q1;
            Q1=sQuery(id+"F3.wireOp",EDGE,"E3");
            circularPattern(context, id + "F4", {"entities" : qUnion([Q0]), "axis" : qUnion([Q1]), "angle" : 360 * degree, "instanceCount" : 6, "equalSpace" : true});
        }
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E4", {"center": v(0, 0) * mm, "radius": 15 * mm});
            skCircle(sketch, "E5", {"center": v(0, 0) * mm, "radius": 30 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E4")}),-1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E4")}),1.0]])]});
            extrude(context, id + "F6", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : false, "secondDirectionDepth" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F5.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F5.wireOp",EDGE,"E4")}),-1.0]])]});
            var Q1;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E1");Q1=makeQuery(id+"F6.boolean.opBoolean","INTERSECT",VERTEX,{"derivedFrom":[makeQuery(id+"F4.opPattern","COPY",FACE,{"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),subQ0,sQuery(id+"F0.wireOp",EDGE,"E2")])],"isStart":false}),"instanceName":"4"}),makeQuery(id+"F4.opPattern","COPY",FACE,{"derivedFrom":makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ0])]}),"instanceName":"4"}),makeQuery(id+"F6.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F5.wireOp",EDGE,"E5")])]})]});}
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "endBound" : BoundingType.UP_TO_VERTEX, "endBoundEntityVertex" : qUnion([Q1]), "depth" : 25 * mm});
        }
    });